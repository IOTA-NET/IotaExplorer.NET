using IotaExplorerNet.Domain.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace IotaExplorerNet.Domain.Common.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddIotaExplorerServices(this IServiceCollection serviceDescriptors)
        {
            
            serviceDescriptors
                .AddSingleton(testnetApiProvider => new Func<string, ITestnetExplorerApi>((url) =>
                {
                    NewtonsoftJsonContentSerializer newtonsoftJsonContentSerializer = new NewtonsoftJsonContentSerializer();
                    RefitSettings refitSettings = new RefitSettings(contentSerializer: newtonsoftJsonContentSerializer);

                    return  RestService.For<ITestnetExplorerApi>(url, refitSettings);
                }));

            return serviceDescriptors;
        }
    }
}
