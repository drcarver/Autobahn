//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStudentEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStudentEmployment Interface
     /// </summary>
    public partial interface IAeStudentEmployment : IAutobahnBase
    {
        /// <summary>
        /// Employment NAICS Code
        /// <para>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
        /// </para>
        /// </summary>
        System.String EmploymentNaicsCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
