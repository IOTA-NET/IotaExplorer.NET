namespace IotaExplorerNet.Domain.Common
{
    public static class TestnetRoutesResolver
    {
        public const string AddressBalanceRoute = "/stardust/balance/testnet/{address}";
        public const string TransactionHistoryRoute = "/stardust/transactionhistory/testnet/{address}?pageSize=10&sort=newest";
        public const string OutputDetailsRoute = "/stardust/output/testnet/{outputId}";
    }

    public static class ShimmerRoutesResolver
    {
        public const string AddressBalanceRoute = "/stardust/balance/shimmer/{address}";
        public const string TransactionHistoryRoute = "/stardust/transactionhistory/shimmer/{address}?pageSize=10&sort=newest";
        public const string OutputDetailsRoute = "/stardust/output/shimmer/{outputId}";

    }
}
