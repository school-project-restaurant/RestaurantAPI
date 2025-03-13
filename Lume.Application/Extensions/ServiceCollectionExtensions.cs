using Microsoft.Extensions.DependencyInjection;
using Lume.Application.Prenotations;

namespace Lume.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPrenotationService, PrenotationService>();
    }
}