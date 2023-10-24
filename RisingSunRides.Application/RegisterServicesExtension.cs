using Microsoft.Extensions.DependencyInjection;

namespace RisingSunRides.Application
{
    public static class RegisterServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IAdvertisementService, AdvertisementService>();
        }
    }
}
