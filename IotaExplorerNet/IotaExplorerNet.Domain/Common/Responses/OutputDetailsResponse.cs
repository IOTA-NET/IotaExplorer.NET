using IotaWalletNet.Domain.Common.Interfaces;
using IotaWalletNet.Domain.Common.Models.Explorer;

namespace IotaExplorerNet.Domain.Common.Responses
{
    public class OutputDetailsResponse
    {
        //public OutputDetailsResponse(IOutputType output, OutputMetadataResponse metadata)
        //{
        //    this.output = output;
        //    this.metadata = metadata;
        //}

        //public IOutputType? output { get; set; }
        public OutputResponse Output { get; set; }

    }

    public class OutputResponse
    {
        //public OutputDetailsResponse(IOutputType output, OutputMetadataResponse metadata)
        //{
        //    this.output = output;
        //    this.metadata = metadata;
        //}

        public IOutputType? Output { get; set; }

        public OutputMetadataResponse Metadata { get; set; } = new OutputMetadataResponse();
    }

    public class OutputMetadataResponse
    {

        /**
        * The block id the output was contained in.
        */
        public string? BlockId { get; set; }

        /**
         * The transaction id for the output.
         */
        public string? TransactionId { get; set; }

        /**
         * The index for the output.
         */
        public uint OutputIndex { get; set; }
        /**
         * Is the output spent.
         */
        public bool IsSpent { get; set; }

        /**
         * The milestone index at which this output was booked into the ledger.
         */
        public uint MilestoneIndexBooked { get; set; }

        /**
         * The milestone timestamp this output was booked in the ledger.
         */
        public uint MilestoneTimestampBooked { get; set; }

        /**
         * The ledger index at which these output was available at.
         */
        public uint LedgerIndex { get; set; }
    }

}
