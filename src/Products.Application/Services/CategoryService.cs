using Products.Application.DTOs.Category.Request;
using Products.Application.DTOs.Category.Response;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Services
{
    public sealed class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository) { }

        public async Task<CategoryResponse> InsertCategoryAsync(CategoryRequest categoryRequest)
            => new CategoryResponse((await InsertAsync(new Category(categoryRequest.Name))).Name);
    }
}
