//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramService
     /// </summary>
    public partial class IndividualizedProgramService : IIndividualizedProgramService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDelivery"/> model
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequency"/> model
        /// </summary>
        public Guid? RefServiceFrequencyId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.PlannedServiceDuration nullable property
        /// </summary>
        public System.Decimal? PlannedServiceDuration { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.PlannedServiceStartDate nullable property
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.RecordEndDateTime nullable property
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
