using Products.Application.DTOs.Product.Requests;
using Products.Application.DTOs.Products.Responses;
using Products.Application.Interfaces.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Interfaces.Services
{
    public interface IProductService : IBaseService<Product>
    {
        Task<ProductResponse> InsertProductAsync(ProductRequest productRequest);
        Task<List<ProductResponse>> GetAllProducts();
    }
}
