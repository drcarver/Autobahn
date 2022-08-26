//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAdmissionTest.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Postsecondary
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
        /// Standardized Admission Test Type
        /// <para>
        /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
        /// </para>
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
        Decimal? StandardizedAdmissionTestScore { get; set; }

    }
}
