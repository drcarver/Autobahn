//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceProgramParticipantCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipantCohortModel Interface
     /// </summary>
    public partial interface IWorkforceProgramParticipantCohortModel : IAutobahnBase
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
