//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentActivity.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentActivity
     /// </summary>
    public partial class ProfessionalDevelopmentActivity : AutobahnBase, Interfaces.IProfessionalDevelopmentActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ActivityIdentifier non nullable property
        /// </summary>
        public System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Objective non nullable property
        /// </summary>
        public System.String Objective { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ActivityCode non nullable property
        /// </summary>
        public System.String ActivityCode { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ApprovalCode non nullable property
        /// </summary>
        public System.String ApprovalCode { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Cost nullable property
        /// </summary>
        public System.Decimal? Cost { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.Credits nullable property
        /// </summary>
        public System.Decimal? Credits { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ScholarshipStatus nullable property
        /// </summary>
        public System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.PublishIndicator nullable property
        /// </summary>
        public System.Boolean? PublishIndicator { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentActivity.ProfessionalDevelopmentActivityStateApprovedStatus nullable property
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceType"/> model
        /// </summary>
        public Guid? RefPDAudienceTypeId { get; set; }

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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
