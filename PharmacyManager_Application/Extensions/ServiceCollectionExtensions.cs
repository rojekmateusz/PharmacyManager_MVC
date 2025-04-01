using Microsoft.Extensions.DependencyInjection;
using PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;
using PharmacyManager_Domain.Entities;
using MediatR;

namespace PharmacyManager_Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

        services.AddAutoMapper(applicationAssembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));
    }
}
