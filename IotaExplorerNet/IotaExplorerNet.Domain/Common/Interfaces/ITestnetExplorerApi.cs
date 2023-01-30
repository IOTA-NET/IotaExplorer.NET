using IotaExplorerNet.Domain.Common.Responses;
using Refit;

namespace IotaExplorerNet.Domain.Common.Interfaces
{

    [Headers("Content-Type: application/json")]
    public interface ITestnetExplorerApi
    {
        [Get("/stardust/balance/testnet/{address}")]
        Task<AddressBalanceResponse> GetAddressBalance(string address);

        [Get("/stardust/transaction/testnet/:transactionId")]
        Task<string> GetTransactionAsync(string transactionId);
    }

}