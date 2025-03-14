using Microsoft.Extensions.DependencyInjection;
using Lume.Application.Prenotations;

namespace Lume.Application.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add the application services to the DI container
    /// </summary>
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPrenotationService, PrenotationService>();
    }
}