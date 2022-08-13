//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SeaFederalFunds.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFunds Interface
     /// </summary>
    public partial interface IK12SeaFederalFunds : IAutobahnBase
    {
        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        System.DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        Guid K12SeaId { get; set; }

        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        System.Decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        System.Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
