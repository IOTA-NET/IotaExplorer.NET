using IotaExplorerNet.Domain.Common.Extensions;
using IotaExplorerNet.Domain.Common.Interfaces;
using IotaExplorerNet.Domain.Common.Responses;
using IotaWalletNet.Domain.Common.Extensions;
using IotaWalletNet.Domain.Common.Interfaces;
using IotaWalletNet.Domain.Common.Models.Output.FeatureTypes;
using IotaWalletNet.Domain.Common.Models.Output.OutputTypes;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

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

            //var x = await testnetExplorerApi.GetNftBalanceAsync("rms1qptynkddm3gjgmuwtstfzy529j4r55z9r5qeszedxncy3p5uurerwm85n0r");
            //Console.WriteLine(x);

            //AddressBalanceResponse addressBalanceResponse = await testnetExplorerApi.GetAddressBalance("rms1qptynkddm3gjgmuwtstfzy529j4r55z9r5qeszedxncy3p5uurerwm85n0r");
            //Console.WriteLine(addressBalanceResponse);

            var x = await testnetExplorerApi.GetTransactionHistoryAsync("rms1qp2qnal79rglwe2mc60ee8crhk2pnk4yt0v4jt6kuwz8sactau6yyevsatr");
            Console.WriteLine(JsonConvert.SerializeObject(x.Content, Formatting.Indented));
            TransactionHistoryResponse transactionHistoryResponse = x.Content!;

            var outputIdsList = transactionHistoryResponse.Items.Select(x => x.OutputId).ToList();

            foreach (var outputId in outputIdsList)
            {
                var r = await testnetExplorerApi.GetOutputDetailsAsync(outputId);
                var outputDetails = r.Content!;
                if (outputDetails.Output!.Output!.Type != 3)
                    continue;

                var basicOutput = (BasicOutput)outputDetails.Output.Output;
                if (basicOutput.Features?.Any(x => x.Type == 2) == true)
                {
                    // The collection is not null and contains an element with Type == 2
                    var metadata = (MetadataFeature)basicOutput.Features.First(x => x.Type == 2);
                    string data = metadata.Data.FromHexString();

                    Console.WriteLine(data);
                }


            }


        }
    }
}