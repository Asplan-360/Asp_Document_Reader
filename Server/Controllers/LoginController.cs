using Microsoft.AspNetCore.Mvc;
using Asp_Document_Reader.Server.Services;

namespace Asp_Document_Reader.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<UserResponse> Post([FromBody] UserInfo user)
        {
            var retorno = _service.Login(user);
            return retorno;
        }
    }
}
