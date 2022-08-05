//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCohort.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCohort
     /// </summary>
    public partial class PsStudentCohort : AutobahnBase, Interfaces.IPsStudentCohort
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentCohort.CohortGraduationYear non nullable property
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
