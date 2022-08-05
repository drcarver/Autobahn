//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramService.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramService
     /// </summary>
    public partial class IndividualizedProgramService : AutobahnBase, Interfaces.IIndividualizedProgramService
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
