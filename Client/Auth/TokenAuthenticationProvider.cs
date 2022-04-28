using Asp_Document_Reader.Client.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace Asp_Document_Reader.Client.Auth;

public class TokenAuthenticationProvider : AuthenticationStateProvider, IAuthorizeService
{
    private readonly IJSRuntime _js;
    private readonly HttpClient _http;
    public static readonly string tokenkey = "tokenkey";

    public TokenAuthenticationProvider(IJSRuntime js, HttpClient http)
    {
        _js = js;
        _http = http;
    }

    private AuthenticationState notAuthenticate =>
        new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var token = await _js.GetFromLocalStorage(tokenkey);

        if (string.IsNullOrEmpty(token))
        {
            return notAuthenticate;
        }
        return CreateAuthenticationState(token);
    }
    public AuthenticationState CreateAuthenticationState(string token)
    {
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("bearer", token);

        return new AuthenticationState(new ClaimsPrincipal
            (new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt")));


    }
    private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
    {
        var claims = new List<Claim>();
        var payload = jwt.Split('.')[1];
        var jsonBytes = ParseBase64WithoutPadding(payload);
        var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

        if (roles != null)
        {
            if (roles.ToString().Trim().StartsWith("["))
            {
                var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                foreach (var parsedRole in parsedRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
            }

            keyValuePairs.Remove(ClaimTypes.Role);
        }

        claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

        return claims;
    }

    private byte[] ParseBase64WithoutPadding(string base64)
    {
        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }
        return Convert.FromBase64String(base64);
    }

    public async Task Login(string token)
    {
        try
        {
            await _js.SetInLocalStorage(tokenkey, token);
            var authState = CreateAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }
        catch (Exception)
        {
            throw;
        }

    }

    public async Task Logout()
    {


        try
        {
            await _js.RemoveItem(tokenkey);
            _http.DefaultRequestHeaders.Authorization = null;
            NotifyAuthenticationStateChanged(Task.FromResult(notAuthenticate));
        }
        catch (Exception)
        {

            throw;
        }
    }
}
