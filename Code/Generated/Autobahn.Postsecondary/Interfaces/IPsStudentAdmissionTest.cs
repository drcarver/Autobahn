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
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// Standardized Admission Test Score
        /// <para>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
        /// </para>
        /// </summary>
        System.Decimal? StandardizedAdmissionTestScore { get; set; }

    }
}
