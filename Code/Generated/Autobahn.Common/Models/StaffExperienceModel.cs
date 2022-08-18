//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffExperience Model
     /// </summary>
    public partial class StaffExperienceModel : AutobahnBase, Interfaces.IStaffExperience
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// Years of Prior Teaching Experience
        /// <para>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
        /// </para>
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get; set; }

    }
}
