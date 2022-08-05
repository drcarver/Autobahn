//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffProfessionalDevelopmentActivity.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivity
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivity : AutobahnBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityTitle non nullable property
        /// </summary>
        public System.String ActivityTitle { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityIdentifier non nullable property
        /// </summary>
        public System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityStartDate nullable property
        /// </summary>
        public System.DateTime? ActivityStartDate { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityCompletionDate nullable property
        /// </summary>
        public System.DateTime? ActivityCompletionDate { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ScholarshipStatus nullable property
        /// </summary>
        public System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.NumberOfCreditsEarned nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
