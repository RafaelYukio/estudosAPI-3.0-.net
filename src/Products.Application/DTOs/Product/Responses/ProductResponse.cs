namespace Products.Application.DTOs.Products.Responses
{
    public record ProductResponse
    (
        Guid Id,
        string Name,
        int Quantity,
        string Description,
        string Category,
        IEnumerable<string> Tags
    );
}
