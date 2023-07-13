using Products.Application.DTOs.Category.Request;
using Products.Application.DTOs.Category.Response;
using Products.Application.Interfaces.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Interfaces.Services
{
    public interface ICategoryService : IBaseService<Category>
    {
        Task<CategoryResponse> InsertCategoryAsync(CategoryRequest categoryRequest);
    }
}
