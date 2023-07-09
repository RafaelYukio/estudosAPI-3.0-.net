using Products.Identity.Application.DTOs.Requests;
using Products.Identity.Application.DTOs.Responses;

namespace Products.Identity.Application.Interfaces
{
    public interface IAuthenticationService
    {
        LoginResponse Login(LoginRequest loginRequest);
        void Register (RegisterRequest registerRequest);
    }
}
