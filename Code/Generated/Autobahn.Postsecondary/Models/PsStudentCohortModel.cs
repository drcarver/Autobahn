//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortModel.cs
//***************************************************************************

using Autobahn.Interfaces.Postsecondary;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCohort Model
     /// </summary>
    public partial class PsStudentCohortModel : AutobahnBase, IPsStudentCohort
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
