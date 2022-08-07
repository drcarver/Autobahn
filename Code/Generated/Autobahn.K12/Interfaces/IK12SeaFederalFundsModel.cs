//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SeaFederalFundsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFundsModel Interface
     /// </summary>
    public partial interface IK12SeaFederalFundsModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Sea"/> model
        /// </summary>
        Guid K12SeaId { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.StateTransferabilityOfFunds nullable property
        /// </summary>
        System.Boolean? StateTransferabilityOfFunds { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.DateStateReceivedTitleIIIAllocation nullable property
        /// </summary>
        System.DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.DateTitleIIIFundsAvailableToSubgrantees nullable property
        /// </summary>
        System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.NumberOfDaysForTitleIIISubgrants nullable property
        /// </summary>
        System.Decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

    }
}
