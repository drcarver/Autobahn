//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStaff.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStaff Interface
     /// </summary>
    public partial interface IAeStaff : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

    }
}
