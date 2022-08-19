using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELStaffEmployment")]
    public partial class ELStaffEmployment
    {
        public int ELStaffEmploymentId { get; set; }

        public int StaffEmploymentId { get; set; }

        public decimal? HoursWorkedPerWeek { get; set; }

        public decimal? HourlyWage { get; set; }

        public bool? UnionMembershipStatus { get; set; }

        public bool? StaffApprovalIndicator { get; set; }

        public int? RefEmploymentStatusId { get; set; }

        public int? RefWageCollectionMethodId { get; set; }

        public int? RefWageVerificationId { get; set; }

        public int? RefELEducationStaffClassificationId { get; set; }

        public int? RefELEmploymentSeparationReasonId { get; set; }

        public int? RefELServiceProfessionalStaffClassificationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELEducationStaffClassification RefELEducationStaffClassification { get; set; }

        public virtual RefELEmploymentSeparationReason RefELEmploymentSeparationReason { get; set; }

        public virtual RefELServiceProfessionalStaffClassification RefELServiceProfessionalStaffClassification { get; set; }

        public virtual RefEmploymentStatus RefEmploymentStatus { get; set; }

        public virtual RefWageCollectionMethod RefWageCollectionMethod { get; set; }

        public virtual RefWageVerification RefWageVerification { get; set; }

        public virtual StaffEmployment StaffEmployment { get; set; }
    }
}
