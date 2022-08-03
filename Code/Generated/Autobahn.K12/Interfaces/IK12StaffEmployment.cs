//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StaffEmployment.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffEmployment
     /// </summary>
    public partial interface IK12StaffEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.ContractDaysOfServicePerYear nullable property
        /// </summary>
        System.Decimal? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.MepPersonnelIndicator nullable property
        /// </summary>
        System.Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.TitleITargetedAssistanceStaffFunded nullable property
        /// </summary>
        System.Boolean? TitleITargetedAssistanceStaffFunded { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.SalaryForTeachingAssignmentOnlyIndicator nullable property
        /// </summary>
        System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.RecordEndDateTime nullable property
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
