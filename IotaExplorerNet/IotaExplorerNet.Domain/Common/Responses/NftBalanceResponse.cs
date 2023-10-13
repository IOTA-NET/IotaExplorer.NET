namespace IotaExplorerNet.Domain.Common.Responses
{
    public class Address
    {
        public int Type { get; set; }
        public string PubKeyHash { get; set; } = string.Empty;
        public string NftId { get; set; } = string.Empty;
    }

    public class ImmutableFeature
    {
        public int Type { get; set; }
        public Address Address { get; set; } = new Address();
        public string Data { get; set; }
    }

    public class NftBalanceOutputMetadata
    {
        public string BlockId { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public int OutputIndex { get; set; }
        public bool IsSpent { get; set; }
        public int MilestoneIndexBooked { get; set; }
        public int MilestoneTimestampBooked { get; set; }
        public int LedgerIndex { get; set; }
    }

    public class NftBalanceOutputDetails
    {
        public NftBalanceOutputMetadata Metadata { get; set; } = new NftBalanceOutputMetadata();
        public NftBalanceOutput Output { get; set; } = new NftBalanceOutput();
    }

    public class NftBalanceOutput
    {
        public int Type { get; set; }
        public string Amount { get; set; } = string.Empty;
        public string NftId { get; set; } = string.Empty;
        public List<UnlockCondition> UnlockConditions { get; } = new List<UnlockCondition>();
        public List<ImmutableFeature> ImmutableFeatures { get; } = new List<ImmutableFeature>();
    }

    public class NftBalancesResponse
    {
        public List<NftBalanceOutputDetails> Outputs { get; } = new List<NftBalanceOutputDetails>();
    }

    public class UnlockCondition
    {
        public int Type { get; set; }
        public Address Address { get; set; } = new Address();
    }




}
