using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReportBuilderAPI.Application.Interfaces;
using ReportBuilderAPI.Persistence.Context;
using ReportBuilderAPI.Persistence.Repositories;

namespace ReportBuilderAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        services.AddScoped<IHarmanlamaRepository, HarmanlamaRepository>();

    }
}
