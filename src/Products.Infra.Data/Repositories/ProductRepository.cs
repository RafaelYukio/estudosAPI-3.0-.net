
using Microsoft.EntityFrameworkCore;
using Products.Application.Interfaces.Repositories;
using Products.Domain.Entities;
using Products.Infra.Data.Context;
using Products.Infra.Data.Repositories.Base;

namespace Products.Infra.Data.Repositories
{
    public sealed class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context) { }

        public override async Task<Product> GetByIdAsync(Guid id) => await _DbSet
            .AsNoTracking()
            .Include(product => product.Description)
            .Include(product => product.Category)
            .Include(product => product.Tags)
            .FirstOrDefaultAsync(product => product.Id == id);

        public override async Task<List<Product>> GetAllAsync() => await _DbSet
            .Include(product => product.Description)
            .Include(product => product.Category)
            .Include(product => product.Tags)
            .AsNoTracking().ToListAsync();
    }
}
