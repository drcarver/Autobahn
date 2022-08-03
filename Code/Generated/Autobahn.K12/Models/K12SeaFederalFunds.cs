//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaFederalFunds.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaFederalFunds
     /// </summary>
    public partial class K12SeaFederalFunds : IK12SeaFederalFunds
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Sea"/> model
        /// </summary>
        public Guid K12SeaId { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.StateTransferabilityOfFunds nullable property
        /// </summary>
        public System.Boolean? StateTransferabilityOfFunds { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.DateStateReceivedTitleIIIAllocation nullable property
        /// </summary>
        public System.DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.DateTitleIIIFundsAvailableToSubgrantees nullable property
        /// </summary>
        public System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.NumberOfDaysForTitleIIISubgrants nullable property
        /// </summary>
        public System.Decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SeaFederalFunds.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
