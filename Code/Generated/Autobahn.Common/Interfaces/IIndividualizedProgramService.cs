//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramService.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramService
     /// </summary>
    public partial interface IIndividualizedProgramService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceType"/> model
        /// </summary>
        Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDelivery"/> model
        /// </summary>
        Guid? RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequency"/> model
        /// </summary>
        Guid? RefServiceFrequencyId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.PlannedServiceDuration nullable property
        /// </summary>
        System.Decimal? PlannedServiceDuration { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.PlannedServiceStartDate nullable property
        /// </summary>
        System.DateTime? PlannedServiceStartDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramService.RecordEndDateTime nullable property
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
