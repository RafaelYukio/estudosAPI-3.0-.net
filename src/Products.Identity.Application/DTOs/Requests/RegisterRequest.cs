namespace Products.Identity.Application.DTOs.Requests
{
    public record RegisterRequest
    (
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}
