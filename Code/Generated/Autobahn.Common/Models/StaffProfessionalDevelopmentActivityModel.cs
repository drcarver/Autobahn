//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityModel.cs
//* Name:       Staff Professional Development Activity Completion Date
//* Definition: The year, month and day on which an individual completed a course, an education program or a staff development activity.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// Staff Professional Development Activity Completion Date
        /// <para>
        /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20068">Staff Professional Development Activity Completion Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ActivityCompletionDate { get; set; }

        /// <summary>
        /// Professional Development Activity Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
        /// </para>
        /// </summary>
        public System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Staff Professional Development Activity Start Date
        /// <para>
        /// The year, month and day on which an individual begins a course, an education program or a staff development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20067">Staff Professional Development Activity Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ActivityStartDate { get; set; }

        /// <summary>
        /// Professional Development Activity Title
        /// <para>
        /// The title of an activity designed for the purpose of developing someone professionally.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
        /// </para>
        /// </summary>
        public System.String ActivityTitle { get; set; }

        /// <summary>
        /// Number of Credits Earned
        /// <para>
        /// The number of credits an individual earns by the successful completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Professional Development Session Capacity
        /// <para>
        /// The total number of participants that can be accommodated by a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
        /// </para>
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Professional Development Scholarship Status
        /// <para>
        /// An indication of whether a scholarship was received for the person to participate in the professional development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? ScholarshipStatus { get; set; }

    }
}
