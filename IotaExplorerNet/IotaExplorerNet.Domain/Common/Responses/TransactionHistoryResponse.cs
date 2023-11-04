namespace IotaExplorerNet.Domain.Common.Responses
{
    public class TransactionHistoryResponse
    {
        public string Address { get; set; } = "";

        public List<OutputTransactionHistory> Items { get; set; } = new();
    }

    public class OutputTransactionHistory
    {
        public string OutputId { get; set; } = "";

        public bool IsSpent { get; set; } = false;

        public int MilestoneIndex { get; set; }

        public int MilestoneTimestamp { get; set; }
    }
}
