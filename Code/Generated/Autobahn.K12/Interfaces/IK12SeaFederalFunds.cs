//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SeaFederalFunds.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFunds
     /// </summary>
    public partial interface IK12SeaFederalFunds
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

        /// <summary>
        /// Defines the K12SeaFederalFunds.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
