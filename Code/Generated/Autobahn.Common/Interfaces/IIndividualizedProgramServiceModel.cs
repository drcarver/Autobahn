//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramServiceModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramServiceModel : IAutobahnBase
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

    }
}
