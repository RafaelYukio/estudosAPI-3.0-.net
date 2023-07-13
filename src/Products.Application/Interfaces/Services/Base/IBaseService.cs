using Products.Domain.Entities.Base;

namespace Products.Application.Interfaces.Services.Base
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(Guid id);
    }
}
