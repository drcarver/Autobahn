//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffEmployment.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffEmployment
     /// </summary>
    public partial class K12StaffEmployment : IK12StaffEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.ContractDaysOfServicePerYear nullable property
        /// </summary>
        public System.Decimal? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.MepPersonnelIndicator nullable property
        /// </summary>
        public System.Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.TitleITargetedAssistanceStaffFunded nullable property
        /// </summary>
        public System.Boolean? TitleITargetedAssistanceStaffFunded { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.SalaryForTeachingAssignmentOnlyIndicator nullable property
        /// </summary>
        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
