//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentActivityModel Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentActivityModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        Guid? CourseId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ActivityIdentifier non nullable property
        /// </summary>
        System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Objective non nullable property
        /// </summary>
        System.String Objective { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ActivityCode non nullable property
        /// </summary>
        System.String ActivityCode { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ApprovalCode non nullable property
        /// </summary>
        System.String ApprovalCode { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Cost nullable property
        /// </summary>
        System.Decimal? Cost { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Credits nullable property
        /// </summary>
        System.Decimal? Credits { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ScholarshipStatus nullable property
        /// </summary>
        System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.PublishIndicator nullable property
        /// </summary>
        System.Boolean? PublishIndicator { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ProfessionalDevelopmentActivityStateApprovedStatus nullable property
        /// </summary>
        System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceType"/> model
        /// </summary>
        Guid? RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityApprovedPurpose"/> model
        /// </summary>
        Guid? RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityCreditType"/> model
        /// </summary>
        Guid? RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityLevel"/> model
        /// </summary>
        Guid? RefPDActivityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityType"/> model
        /// </summary>
        Guid? RefPDActivityTypeId { get; set; }

    }
}
