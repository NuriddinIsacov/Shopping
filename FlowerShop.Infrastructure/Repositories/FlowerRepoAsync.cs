using FlowerShop.Domain.Models;
using FlowerShop.Infrastructure.Context;
using FlowerShop.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Infrastructure.Repositories
{
    public class FlowerRepoAsync : GenericRepositoryAsync<Flower>,  IFlowerRepoAsync
    {
        private readonly DbSet<Flower> flowers;

        public FlowerRepoAsync(ApplicationDbContext context) : base(context)
        {
            flowers = context.Set<Flower>();
        }
    }
}
