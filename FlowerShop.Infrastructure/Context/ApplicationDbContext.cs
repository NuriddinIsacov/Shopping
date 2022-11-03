using FlowerShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlowerShop.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}
