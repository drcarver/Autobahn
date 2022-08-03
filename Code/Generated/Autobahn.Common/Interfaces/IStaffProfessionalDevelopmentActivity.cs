//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffProfessionalDevelopmentActivity.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffProfessionalDevelopmentActivity
     /// </summary>
    public partial interface IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityTitle non nullable property
        /// </summary>
        System.String ActivityTitle { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityIdentifier non nullable property
        /// </summary>
        System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityStartDate nullable property
        /// </summary>
        System.DateTime? ActivityStartDate { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ActivityCompletionDate nullable property
        /// </summary>
        System.DateTime? ActivityCompletionDate { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.ScholarshipStatus nullable property
        /// </summary>
        System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.NumberOfCreditsEarned nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffProfessionalDevelopmentActivity.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
