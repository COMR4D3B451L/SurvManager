using SurvManager.Models;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace SurvManager.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        public static void ConfigureIisIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(option => {});

        public static void ConfigureDbContext(this IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            services.AddDbContext<ManagerContext>(options => options.UseNpgsql(configuration.GetConnectionString("Postgres")));

        }

    }

    

}
