//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceProgramParticipantCohort.cs
//**********************************************************

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipantCohort
     /// </summary>
    public partial interface IWorkforceProgramParticipantCohort
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.CohortDescription non nullable property
        /// </summary>
        System.String CohortDescription { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.CohortMedianEarnings nullable property
        /// </summary>
        System.Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipantCohort.RecordEndDateTime nullable property
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
