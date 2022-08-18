//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentActivityModel.cs
//* Name:       Professional Development Activity Code
//* Definition: A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
     /// </summary>
    public partial class ProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IProfessionalDevelopmentActivity
    {
        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        public System.String ActivityCode { get; set; }

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
        /// Professional Development Activity Approval Code
        /// <para>
        /// A code given to an activity by an approval organization to designate it as an approved activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
        /// </para>
        /// </summary>
        public System.String ApprovalCode { get; set; }

        /// <summary>
        /// Professional Development Activity Cost
        /// <para>
        /// The cost for an attendee to participate in a professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
        /// </para>
        /// </summary>
        public System.Decimal? Cost { get; set; }

        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Professional Development Activity Credits
        /// <para>
        /// The number of credits a professional development activity provides.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
        /// </para>
        /// </summary>
        public System.Decimal? Credits { get; set; }

        /// <summary>
        /// Professional Development Activity Objective
        /// <para>
        /// The expected outcomes of a participant in an activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
        /// </para>
        /// </summary>
        public System.String Objective { get; set; }

        /// <summary>
        /// Professional Development Activity State Approved Status
        /// <para>
        /// An indication of whether a training activity has been approved through a state process.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Professional Development Publish Activity Indicator
        /// <para>
        /// An indicator of whether the professional development activity should be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? PublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityApprovedPurpose"/> model
        /// </summary>
        public Guid? RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityCreditType"/> model
        /// </summary>
        public Guid? RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityLevel"/> model
        /// </summary>
        public Guid? RefPDActivityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityType"/> model
        /// </summary>
        public Guid? RefPDActivityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceType"/> model
        /// </summary>
        public Guid? RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
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

        /// <summary>
        /// Professional Development Activity Title
        /// <para>
        /// The title of an activity designed for the purpose of developing someone professionally.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

    }
}
