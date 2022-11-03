using FlowerShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    }
}
