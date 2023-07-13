using Microsoft.AspNetCore.Mvc;
using Products.Application.DTOs.Category.Request;
using Products.Application.Interfaces.Services;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("category")]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertCategory(CategoryRequest categoryRequest)
            => Created("/categories", (await _categoryService.InsertCategoryAsync(categoryRequest)).Name);
    }
}
