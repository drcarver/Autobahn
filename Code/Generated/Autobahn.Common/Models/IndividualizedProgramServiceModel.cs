//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServiceModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramService Model
     /// </summary>
    public partial class IndividualizedProgramServiceModel : AutobahnBase, Interfaces.IIndividualizedProgramService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Individualized Program Planned Service Duration
        /// <para>
        /// The length, in hours, that delivery of the service is planned.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20493">Individualized Program Planned Service Duration</a>
        /// </para>
        /// </summary>
        public System.Decimal? PlannedServiceDuration { get; set; }

        /// <summary>
        /// Individualized Program Planned Service Start Date
        /// <para>
        /// The date the service is planned to begin.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndividualizedProgramPlannedServiceType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMethodOfServiceDelivery"/> model
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefServiceFrequency"/> model
        /// </summary>
        public Guid? RefServiceFrequencyId { get; set; }

    }
}
