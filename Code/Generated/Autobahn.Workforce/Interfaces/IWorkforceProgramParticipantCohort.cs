//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceProgramParticipantCohort.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipantCohort Interface
     /// </summary>
    public partial interface IWorkforceProgramParticipantCohort : IAutobahnBase
    {
        System.String CohortDescription { get; set; }

        /// <summary>
        /// Cohort Median Earnings
        /// <para>
        /// The midpoint between the lowest and highest quarterly wage, in U.S. dollars, for the total number of persons included in the cohort for the period of time between the Employment Record Reference Period Start Date and Employment Record Reference Period End Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20918">Cohort Median Earnings</a>
        /// </para>
        /// </summary>
        System.Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
