
namespace IotaExplorerNet.Domain.Common.Responses
{
    public class AddressBalanceResponse
    {
        public AddressBalanceResponse(string balance, IReadOnlyDictionary<string, string> nativeTokens, ulong ledgerIndex, string hex, string bech32, int type)
        {
            Balance = balance;
            NativeTokens = nativeTokens;
            LedgerIndex = ledgerIndex;
            Hex = hex;
            Bech32 = bech32;
            Type = type;
        }

        public string Balance { get; set; }

        public IReadOnlyDictionary<string, string> NativeTokens { get; set; } = new Dictionary<string, string>();

        public ulong LedgerIndex { get; set; }

        public string Hex { get; set; }

        public string Bech32 { get; set; }

        public int Type { get; set; }


        //public override string ToString()
        //{
        //    return JsonConvert.SerializeObject(this, Formatting.Indented);
        //}
    }
}
