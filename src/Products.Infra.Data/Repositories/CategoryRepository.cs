using Microsoft.EntityFrameworkCore;
using Products.Application.Interfaces.Repositories;
using Products.Domain.Entities;
using Products.Infra.Data.Context;
using Products.Infra.Data.Repositories.Base;

namespace Products.Infra.Data.Repositories
{
    public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context) { }

        public async Task<Category> GetByNameAsync(string categoryName)
            => await _DbSet.FirstOrDefaultAsync(category => category.Name == categoryName);
    }
}
