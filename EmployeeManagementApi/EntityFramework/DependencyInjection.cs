using EmployeeManagementApi.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<EmployeeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("EmployeeManagementPortal"),
                b => b.MigrationsAssembly(typeof(EmployeeContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<EmployeeContext>(provider => provider.GetService<EmployeeContext>());
            return services;
        }
    }
}
