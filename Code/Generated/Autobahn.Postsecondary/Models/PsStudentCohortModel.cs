//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCohort Model
     /// </summary>
    public partial class PsStudentCohortModel : AutobahnBase, Interfaces.IPsStudentCohort
    {
        /// <summary>
        /// The year the cohort is expected to graduate.
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// The year the cohort is expected to graduate.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
