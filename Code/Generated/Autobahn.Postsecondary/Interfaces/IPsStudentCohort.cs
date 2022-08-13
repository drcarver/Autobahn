//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentCohort.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCohort Interface
     /// </summary>
    public partial interface IPsStudentCohort : IAutobahnBase
    {
        /// <summary>
        /// The year the cohort is expected to graduate.
        /// </summary>
        System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// The year the cohort is expected to graduate.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
