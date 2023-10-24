using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RisingSunRides.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static void AddStorage(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["ConnectionString"]));
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }

        public static void CreateDbIfNotExists(this IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                DbInitializer.Initialize(dbContext).Wait();
            }
        }
    }
}
