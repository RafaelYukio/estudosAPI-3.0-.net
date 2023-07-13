using Products.Application.Interfaces.Repositories.Base;
using Products.Domain.Entities;

namespace Products.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<Category> GetByNameAsync(string categoryName);
    }

}
