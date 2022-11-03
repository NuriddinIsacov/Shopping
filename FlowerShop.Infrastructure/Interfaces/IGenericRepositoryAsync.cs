using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowerShop.Infrastructure.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<List<T>> GetAllProducts();
        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T entity);
    }
}
