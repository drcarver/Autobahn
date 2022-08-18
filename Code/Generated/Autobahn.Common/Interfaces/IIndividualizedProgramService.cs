//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramService.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramService Interface
     /// </summary>
    public partial interface IIndividualizedProgramService : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Individualized Program Planned Service Duration
        /// <para>
        /// The length, in hours, that delivery of the service is planned.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20493">Individualized Program Planned Service Duration</a>
        /// </para>
        /// </summary>
        System.Decimal? PlannedServiceDuration { get; set; }

        /// <summary>
        /// Individualized Program Planned Service Start Date
        /// <para>
        /// The date the service is planned to begin.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime? PlannedServiceStartDate { get; set; }

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

    }
}
