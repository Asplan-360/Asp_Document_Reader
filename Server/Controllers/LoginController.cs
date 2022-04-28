﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Asp_Document_Reader.Server.Controllers;

[Route("[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IConfiguration _configuration;

    public LoginController()
    {

    }

    public LoginController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }



    [HttpGet]
    public string Get()
    {
        return $"LoginController :: {DateTime.Now.ToShortDateString()}";
    }

    [HttpPost("Register")]
    public async Task<ActionResult<UserToken>> Register([FromBody] UserInfo model)
    {
        var user = new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            //incluir o  novo usuário ao perfil user
            await _userManager.AddToRoleAsync(user, "User");

            //incluir um novo usuário com email que começa com admin no perfil Admin
            if (user.Email.StartsWith("admin"))
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return await GenerateToken(model);
        }
        else
        {
            return BadRequest(new { message = "Senha ou Nome do usuário inválidos..." });
        }


    }

    [HttpPost("Login")]
    public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
    {
        var result = await _signInManager.PasswordSignInAsync(userInfo.Email,
            userInfo.Password, isPersistent: false, lockoutOnFailure: false);

        if (result.Succeeded)
        {
            return await GenerateToken(userInfo);
        }
        else
        {
            return BadRequest(new { message = "Login Inválido" });
        }

    }

    private async Task<UserToken> GenerateToken(UserInfo userInfo)
    {
        //var claims = new List<Claim>()
        //{
        //    new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
        //    new Claim(ClaimTypes.Name, userInfo.Email),
        //    new Claim("Thiago", "thiago.gramuglia@asplan.com.br"),
        //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //};

        var user = await _signInManager.UserManager.FindByEmailAsync(userInfo.Email);
        var roles = await _signInManager.UserManager.GetRolesAsync(user);
        var claims = new List<Claim>();
        claims.Add(new Claim(ClaimTypes.Name, userInfo.Email));

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }



        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
        var creds = 
            new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiration = DateTime.UtcNow.AddHours(2);
        var message = "Token JWT criado com sucesso";

        JwtSecurityToken token = new JwtSecurityToken(
            issuer: null,
            audience: null,
            claims: claims,
            expires: expiration,
            signingCredentials: creds);

        return new UserToken()
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expiration = expiration,
            Message = message
        };


    }
}