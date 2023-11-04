using IotaExplorerNet.Domain.Common.Responses;
using Refit;

namespace IotaExplorerNet.Domain.Common.Interfaces
{

    [Headers("Content-Type: application/json")]
    public interface ITestnetExplorerApi
    {
        [Get(TestnetRoutesResolver.AddressBalanceRoute)]
        Task<AddressBalanceResponse> GetAddressBalanceAsync(string address);

        [Get("/stardust/transaction/testnet/{transactionId}")]
        Task<string> GetTransactionAsync(string transactionId);

        [Get("/stardust/address/outputs/nft/testnet/{address}")]
        //Task<ApiResponse<string>> GetNftBalanceAsync(string address);
        Task<ApiResponse<NftBalancesResponse>> GetNftBalanceAsync(string address);

        [Get(TestnetRoutesResolver.TransactionHistoryRoute)]
        Task<ApiResponse<TransactionHistoryResponse>> GetTransactionHistoryAsync(string address);

        [Get(TestnetRoutesResolver.OutputDetailsRoute)]
        //Task<ApiResponse<string>> GetOutputDetailsAsync(string outputId);
        Task<ApiResponse<OutputDetailsResponse>> GetOutputDetailsAsync(string outputId);

    }

}