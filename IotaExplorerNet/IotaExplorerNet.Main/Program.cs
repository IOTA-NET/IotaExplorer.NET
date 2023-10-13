using IotaExplorerNet.Domain.Common.Extensions;
using IotaExplorerNet.Domain.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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

            var x = await testnetExplorerApi.GetNftBalanceAsync("rms1qptynkddm3gjgmuwtstfzy529j4r55z9r5qeszedxncy3p5uurerwm85n0r");
            Console.WriteLine(x);
            string s = @"{""outputs"":[{""metadata"":{""blockId"":""0x022000902b1a41014c66343e8106e0373d1ebef0c46c02322ef2f0d193b64b9b"",""transactionId"":""0x3ad68d91450e60e613d4d350ef4c7a47724c3bcab3466ef5811c4f668349371f"",""outputIndex"":0,""isSpent"":false,""milestoneIndexBooked"":7456755,""milestoneTimestampBooked"":1695952313,""ledgerIndex"":7693149},""output"":{""type"":6,""amount"":""92000"",""nftId"":""0x48179e2655a99ce58b24cacb10e1d8f466af302cc8e1b5fb08bd7d6c00d5aa57"",""unlockConditions"":[{""type"":0,""address"":{""type"":0,""pubKeyHash"":""0x5649d9addc51246f8e5c1691128a2caa3a50451d01980b2d34f048869ce0f237""}}],""immutableFeatures"":[{""type"":1,""address"":{""type"":16,""nftId"":""0xc9210f64c3455f6ffbcb7bb7af587dafea79a9f1158db5512068d2fae293ce7f""}},{""type"":2,""data"":""0x7b227374616e64617264223a224952433237222c2276657273696f6e223a2276312e30222c2274797065223a226170706c69636174696f6e2f6a736f6e222c22757269223a2268747470733a2f2f6769746875622e636f6d2f546f6b656e4761746557656233222c226e616d65223a224964656e74697479546f6b656e222c22636f6c6c656374696f6e4e616d65223a6e756c6c2c226973737565724e616d65223a6e756c6c2c226465736372697074696f6e223a6e756c6c2c22726f79616c74696573223a7b7d2c2261747472696275746573223a5b7b22747261697454797065223a2276657273696f6e222c2276616c7565223a22312e30227d2c7b22747261697454797065223a22757365726e616d65222c2276616c7565223a224461736861204e616e676c65227d2c7b22747261697454797065223a2261646472657373222c2276616c7565223a22726d7331717074796e6b64646d33676a676d7577747374667a793532396a347235357a3972357165737a6564786e63793370357575726572776d38356e3072227d5d2c22696e7465726e616c41747472696275746573223a5b5d7d""}]}}]}
";
            //var xx= JsonConvert.DeserializeObject<NftBalancesResponse>(x.Content!);

            //AddressBalanceResponse addressBalanceResponse = await testnetExplorerApi.GetAddressBalance("rms1qptynkddm3gjgmuwtstfzy529j4r55z9r5qeszedxncy3p5uurerwm85n0r");
            //Console.WriteLine(addressBalanceResponse);

            //var r = await testnetExplorerApi.GetTransactionAsync("0xc7246c93cf58541d040d791104be7fee3c7a5e7d73fae3a09dadd47f6c56ee4c");
            //Console.WriteLine(r);
            //0x8137f2fc2f2874ffa036e38450b8922d552d4d77880e8ce52a0100bbdd9546dd block
        }
    }
}