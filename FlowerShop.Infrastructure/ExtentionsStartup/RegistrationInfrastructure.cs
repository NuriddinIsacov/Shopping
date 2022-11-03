using FlowerShop.Infrastructure.Context;
using FlowerShop.Infrastructure.Interfaces;
using FlowerShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FlowerShop.Infrastructure.ExtentionsStartup
{
    public static class RegistrationInfrastructure
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options
                    .UseNpgsql(configuration
                    .GetConnectionString("connectionString")));

            services.AddScoped<IFlowerRepoAsync, FlowerRepoAsync>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        }
    }
}
