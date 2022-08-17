//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentActivity.cs
//* Name:       Professional Development Activity Code
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProfessionalDevelopmentActivity : IAutobahnBase
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
        System.String ActivityCode { get; set; }

        /// <summary>
        /// Professional Development Activity Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
        /// </para>
        /// </summary>
        System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Professional Development Activity Approval Code
        /// <para>
        /// A code given to an activity by an approval organization to designate it as an approved activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
        /// </para>
        /// </summary>
        System.String ApprovalCode { get; set; }

        /// <summary>
        /// Professional Development Activity Cost
        /// <para>
        /// The cost for an attendee to participate in a professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
        /// </para>
        /// </summary>
        System.Decimal? Cost { get; set; }

        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        Guid? CourseId { get; set; }

        /// <summary>
        /// Professional Development Activity Credits
        /// <para>
        /// The number of credits a professional development activity provides.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
        /// </para>
        /// </summary>
        System.Decimal? Credits { get; set; }

        /// <summary>
        /// Professional Development Activity Objective
        /// <para>
        /// The expected outcomes of a participant in an activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
        /// </para>
        /// </summary>
        System.String Objective { get; set; }

        /// <summary>
        /// Professional Development Activity State Approved Status
        /// <para>
        /// An indication of whether a training activity has been approved through a state process.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
        /// </para>
        /// </summary>
        System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
        /// </summary>
        Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Professional Development Publish Activity Indicator
        /// <para>
        /// An indicator of whether the professional development activity should be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? PublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseCreditUnit"/> model
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDActivityApprovedPurpose"/> model
        /// </summary>
        Guid? RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDActivityCreditType"/> model
        /// </summary>
        Guid? RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDActivityLevel"/> model
        /// </summary>
        Guid? RefPDActivityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDActivityType"/> model
        /// </summary>
        Guid? RefPDActivityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDAudienceType"/> model
        /// </summary>
        Guid? RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Professional Development Scholarship Status
        /// <para>
        /// An indication of whether a scholarship was received for the person to participate in the professional development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
        /// </para>
        /// </summary>
        System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// Professional Development Activity Title
        /// <para>
        /// The title of an activity designed for the purpose of developing someone professionally.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
        /// </para>
        /// </summary>
        System.String Title { get; set; }

    }
}
