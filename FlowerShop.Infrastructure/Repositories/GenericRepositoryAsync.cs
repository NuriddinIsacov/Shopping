using FlowerShop.Infrastructure.Context;
using FlowerShop.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowerShop.Infrastructure.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepositoryAsync(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllProducts() => await context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(long id) => await context.Set<T>().FindAsync(id);
    }
}
