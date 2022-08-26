//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortModel.cs
//***************************************************************************

using Autobahn.Interfaces.Workforce;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort Model
     /// </summary>
    public partial class WorkforceProgramParticipantCohortModel : AutobahnBase, IWorkforceProgramParticipantCohort
    {
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// Cohort Median Earnings
        /// <para>
        /// The midpoint between the lowest and highest quarterly wage, in U.S. dollars, for the total number of persons included in the cohort for the period of time between the Employment Record Reference Period Start Date and Employment Record Reference Period End Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20918">Cohort Median Earnings</a>
        /// </para>
        /// </summary>
        public Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
