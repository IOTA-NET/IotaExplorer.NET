namespace IotaExplorerNet.Domain.Common
{
    public static class RoutesResolver
    {
        public static bool IsTestnet { get; set; } = false;

        public static string GetAddressBalanceRoute()
            => IsTestnet
            ? "/stardust/balance/testnet/{address}"
            : "/stardust/balance/shimmer/{address}";



    }
}
