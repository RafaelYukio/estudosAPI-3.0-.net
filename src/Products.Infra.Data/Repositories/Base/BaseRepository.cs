using Microsoft.EntityFrameworkCore;
using Products.Application.Interfaces.Repositories.Base;
using Products.Domain.Entities.Base;
using Products.Infra.Data.Context;

namespace Products.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly DbSet<T> _DbSet;
        public readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _DbSet = context.Set<T>();
            _context = context;
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            _DbSet.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _DbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id) => await _DbSet.AsNoTracking().FirstOrDefaultAsync(entity => entity.Id == id);

        public virtual async Task<List<T>> GetAllAsync() => await _DbSet.AsNoTracking().ToListAsync();

        public virtual async Task RemoveAsync(Guid id)
        {
            T entity = await GetByIdAsync(id);
            _DbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}