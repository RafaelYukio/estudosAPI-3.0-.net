using Products.Application.DTOs.Product.Requests;
using Products.Application.DTOs.Products.Responses;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Services
{
    public sealed class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository) { }

        public async Task<ProductResponse> InsertProductAsync(ProductRequest productRequest)
        {
            Product product = await InsertAsync(new Product(productRequest.Name, productRequest.Quantity));
            return new ProductResponse(product.Id,
                                       product.Name,
                                       product.Quantity,
                                       product.Description?.Details,
                                       product.Category?.Name,
                                       product.Tags?.Select(tag => tag.Name));
        }

        public async Task<List<ProductResponse>> GetAllProducts()
        {
            return (await GetAllAsync()).Select(product =>
            {
                IEnumerable<string> tags = product.Tags?.Select(tag => tag.Name).ToList();
                return new ProductResponse(product.Id, product.Name, product.Quantity, product.Description?.Details, product.Category?.Name, tags);
            }).ToList();
        }
    }
}
