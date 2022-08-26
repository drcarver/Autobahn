//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffExperience.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IStaffExperience Interface
     /// </summary>
    public partial interface IStaffExperience : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        Decimal? YearsOfPriorAeteachingExperience { get; set; }

        /// <summary>
        /// Years of Prior Teaching Experience
        /// <para>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
        /// </para>
        /// </summary>
        Decimal? YearsOfPriorTeachingExperience { get; set; }

    }
}
