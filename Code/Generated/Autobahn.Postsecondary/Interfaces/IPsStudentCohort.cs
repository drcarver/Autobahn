//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentCohort.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCohort
     /// </summary>
    public partial interface IPsStudentCohort : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentCohort.CohortGraduationYear non nullable property
        /// </summary>
        System.String CohortGraduationYear { get; set; }

    }
}
