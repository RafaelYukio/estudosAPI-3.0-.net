using Microsoft.AspNetCore.Mvc;
using Products.Identity.Application.DTOs.Requests;
using Products.Identity.Application.Interfaces;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            _authenticationService.Register(registerRequest);

            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok(_authenticationService.Login(loginRequest));
        }
    }
}
