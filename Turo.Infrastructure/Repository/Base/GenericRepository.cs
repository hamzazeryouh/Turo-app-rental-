

namespace Turo.Infrastructure.Repository.Base
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;
    using Turo.Application.Helpers;
    using Turo.Infrastructure.Persistence;
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext  _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext  context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T> GetByIdAsync(int id)=> await _dbSet.FindAsync(id);
        public async Task<IEnumerable<T>> GetAllAsync()=>  await _dbSet.ToListAsync();
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate) => await _dbSet.Where(predicate).ToListAsync();
        public async Task AddAsync(T entity)=> await _dbSet.AddAsync(entity);
        public void Update(T entity) => _dbSet.Update(entity);
        public void Delete(T entity)=> _dbSet.Remove(entity);

        public async Task<PaginatedList<T>> GetAllAsync(int pageNumber, int pageSize)
        {
            var totalCount = await _dbSet.CountAsync();
            var items = await _dbSet
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedList<T>(items, totalCount, pageNumber, pageSize);
        }

    }

}
