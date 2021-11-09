using FormsApp.Application.Contracts.Persistence;
using FormsApp.Infrastructure.Data;
using FormsApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FormsApp.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<FormsApp_dbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FormsApp")));
            
            services.AddScoped<IFormsRepository, FormsRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}