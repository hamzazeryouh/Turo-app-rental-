using System;
using System.Linq.Expressions;
using Turo.Infrastructure.Helpers;

namespace Turo.Infrastructure.Repository.Base
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<PaginatedList<T>> GetAllAsync(int pageNumber, int pageSize);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
