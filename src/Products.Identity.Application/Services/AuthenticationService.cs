using Products.Identity.Application.DTOs.Requests;
using Products.Identity.Application.DTOs.Responses;
using Products.Identity.Application.Interfaces;

namespace Products.Identity.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public LoginResponse Login(LoginRequest loginRequest)
        {
            return new LoginResponse(Guid.NewGuid(), "teste", "teste", "teste@teste", "token");
        }

        public void Register(RegisterRequest registerRequest)
        {
            return;
        }
    }
}
