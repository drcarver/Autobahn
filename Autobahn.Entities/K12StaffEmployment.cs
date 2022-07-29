using System;

namespace Autobahn.Entities
{
    public partial class K12StaffEmployment
    {
        public int K12StaffEmploymentId { get; set; }

        public int StaffEmploymentId { get; set; }

        public decimal? ContractDaysOfServicePerYear { get; set; }

        public bool? MepPersonnelIndicator { get; set; }

        public bool? TitleITargetedAssistanceStaffFunded { get; set; }

        public bool? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        public int? RefK12StaffClassificationId { get; set; }

        public int? RefEmploymentStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefK12StaffClassification RefK12StaffClassification { get; set; }

        public virtual RefEmploymentStatu RefEmploymentStatu { get; set; }

        public virtual StaffEmployment StaffEmployment { get; set; }
    }
}
