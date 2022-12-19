using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Guid id);
        Task<TResult> GetAsync<TResult>(Guid id);
        Task<List<T>> GetAllAsync();
        Task<List<TResult>> GetAllAsync<TResult>();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(Guid id);
    }
}
