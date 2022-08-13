//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAdmissionTest.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAdmissionTest Interface
     /// </summary>
    public partial interface IPsStudentAdmissionTest : IAutobahnBase
    {
        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        System.Decimal? StandardizedAdmissionTestScore { get; set; }

    }
}
