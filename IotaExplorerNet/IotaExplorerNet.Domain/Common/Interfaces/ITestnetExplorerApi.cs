using IotaExplorerNet.Domain.Common.Responses;
using Refit;

namespace IotaExplorerNet.Domain.Common.Interfaces
{

    [Headers("Content-Type: application/json")]
    public interface ITestnetExplorerApi
    {
        [Get("/stardust/balance/testnet/{address}")]
        Task<AddressBalanceResponse> GetAddressBalanceAsync(string address);

        [Get("/stardust/transaction/testnet/{transactionId}")]
        Task<string> GetTransactionAsync(string transactionId);

        [Get("/stardust/address/outputs/nft/testnet/{address}")]
        //Task<ApiResponse<string>> GetNftBalanceAsync(string address);
        Task<ApiResponse<NftBalancesResponse>> GetNftBalanceAsync(string address);
    }

}