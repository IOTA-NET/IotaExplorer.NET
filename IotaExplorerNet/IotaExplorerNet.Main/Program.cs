using IotaExplorerNet.Domain.Common.Extensions;
using IotaExplorerNet.Domain.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IotaExplorerNet.Main
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string BASE_URL = "https://explorer-api.shimmer.network/";
            IServiceCollection services = new ServiceCollection().AddIotaExplorerServices();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            using IServiceScope serviceScope = serviceProvider.CreateScope();

            Func<string, ITestnetExplorerApi> testnetExplorerProvider = serviceScope.ServiceProvider.GetRequiredService<Func<string, ITestnetExplorerApi>>();

            ITestnetExplorerApi testnetExplorerApi = testnetExplorerProvider(BASE_URL);

            var result = await testnetExplorerApi.GetAddressBalance("rms1qp8rknypruss89dkqnnuedm87y7xmnmdj2tk3rrpcy3sw3ev52q0vzl42tr");
            Console.WriteLine(result);
        }
    }
}