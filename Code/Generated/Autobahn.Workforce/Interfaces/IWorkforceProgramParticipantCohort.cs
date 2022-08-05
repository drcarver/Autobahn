//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceProgramParticipantCohort.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipantCohort
     /// </summary>
    public partial interface IWorkforceProgramParticipantCohort : IAutobahnBase
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

    }
}
