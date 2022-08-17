//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortModel.cs
//* Name:       Cohort Graduation Year
//* Definition: The year the cohort is expected to graduate.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The year the cohort is expected to graduate.
     /// </summary>
    public partial class PsStudentCohortModel : AutobahnBase, Interfaces.IPsStudentCohort
    {
        /// <summary>
        /// Cohort Graduation Year
        /// <para>
        /// The year the cohort is expected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
        /// </para>
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
