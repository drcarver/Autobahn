//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipantCohort.cs
//**********************************************************

using Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort
     /// </summary>
    public partial class WorkforceProgramParticipantCohort : IWorkforceProgramParticipantCohort
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.CohortDescription non nullable property
        /// </summary>
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.CohortMedianEarnings nullable property
        /// </summary>
        public System.Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.RecordEndDateTime nullable property
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
