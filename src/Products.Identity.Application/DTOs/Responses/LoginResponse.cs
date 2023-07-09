namespace Products.Identity.Application.DTOs.Responses
{
    public record LoginResponse
    (
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
    );
}
