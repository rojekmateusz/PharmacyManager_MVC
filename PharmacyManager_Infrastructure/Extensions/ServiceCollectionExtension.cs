    using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacyManager_Domain.Entities;
using PharmacyManager_Domain.Interfaces;
using PharmacyManager_Infrastructure.Persistance;
using PharmacyManager_Infrastructure.Repositories;
using System.Net;
using System.Runtime.CompilerServices;

namespace PharmacyManager_Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PMDb");

        services.AddDbContext<PMDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IMedicineRepository, MedicineRepository>();
            
    }
}
