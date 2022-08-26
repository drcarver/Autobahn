//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaFederalFundModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12seaFederalFund Model
     /// </summary>
    public partial class K12seaFederalFundModel : AutobahnBase, IK12seaFederalFund
    {
        public DateTime? DateStateReceivedTitleIiiallocation { get; set; }

        public DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        public Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12sea"/> model
        /// </summary>
        public Guid K12seaId { get; set; }

        public Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

        public Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
