using IotaExplorerNet.Domain.Common.Extensions;
using IotaExplorerNet.Domain.Common.Interfaces;
using IotaExplorerNet.Domain.Common.Responses;
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

            //AddressBalanceResponse addressBalanceResponse = await testnetExplorerApi.GetAddressBalance("rms1qp8rknypruss89dkqnnuedm87y7xmnmdj2tk3rrpcy3sw3ev52q0vzl42tr");
            //Console.WriteLine(addressBalanceResponse);

            var r = await testnetExplorerApi.GetTransactionAsync("0xc7246c93cf58541d040d791104be7fee3c7a5e7d73fae3a09dadd47f6c56ee4c");
            Console.WriteLine(r);
            //0x8137f2fc2f2874ffa036e38450b8922d552d4d77880e8ce52a0100bbdd9546dd block
        }
    }
}