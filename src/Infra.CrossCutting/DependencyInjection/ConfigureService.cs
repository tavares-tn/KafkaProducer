using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Infra.CrossCutting.DependencyInejection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection)
        {
            // Manter ordenado
            serviceCollection.AddScoped<IKafkaService, KafkaService>();
        }
    }
}
