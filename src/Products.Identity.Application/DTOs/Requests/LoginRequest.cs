namespace Products.Identity.Application.DTOs.Requests
{
    public record LoginRequest
    (
        string Email,
        string Password
    );
}
