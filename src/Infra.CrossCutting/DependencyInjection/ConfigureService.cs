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
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
            serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
            serviceCollection.AddScoped<IExampleService, ExampleService>();
            serviceCollection.AddScoped<IExternalService, ExternalService>();
            serviceCollection.AddScoped<IMobileService, MobileService>();
            serviceCollection.AddScoped<IOpportunitService, OpportunitService>();
            serviceCollection.AddScoped<ISkillService, SkillService>();
        }
    }
}
