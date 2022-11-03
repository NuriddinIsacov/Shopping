using FlowerShop.Business.Interfaces;
using FlowerShop.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FlowerShop.Business.ExtentionsStartup
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IFlowerServiceAsync, FlowerServiceAsync>();
        }
    }
}
