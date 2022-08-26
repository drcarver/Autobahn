//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12seaFederalFund.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12seaFederalFund Interface
     /// </summary>
    public partial interface IK12seaFederalFund : IAutobahnBase
    {
        DateTime? DateStateReceivedTitleIiiallocation { get; set; }

        DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12sea"/> model
        /// </summary>
        Guid K12seaId { get; set; }

        Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

        Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
