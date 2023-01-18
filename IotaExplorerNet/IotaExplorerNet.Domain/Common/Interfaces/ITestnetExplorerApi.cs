using Refit;

namespace IotaExplorerNet.Domain.Common.Interfaces
{

    [Headers("Content-Type: application/json")]
    public interface ITestnetExplorerApi
    {
        [Get("/stardust/balance/testnet/{address}")]
        Task<string> GetAddressBalance(string address);
    }

}