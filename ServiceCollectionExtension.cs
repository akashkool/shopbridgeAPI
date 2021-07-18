using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StructureMap;

namespace ShopBridgeAPI.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void AddStructureMap(this IServiceCollection services)
        {
            AddStructureMap(services, registry: null);
        }

        public static void AddStructureMap(this IServiceCollection services, Registry registry)
        {
            services.AddSingleton<IServiceProviderFactory<Registry>>(new StructureMapServiceProviderFactory(registry));
        }
    }

    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseStructureMap(this IHostBuilder builder)
        {
            return UseStructureMap(builder, registry: null);
        }

        public static IHostBuilder UseStructureMap(this IHostBuilder builder, Registry registry)
        {
            return builder
               .UseServiceProviderFactory<Registry>(new StructureMapServiceProviderFactory(registry))
               .ConfigureServices(services => services.AddStructureMap(registry));
        }
    }   
}