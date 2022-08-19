using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffCompensation")]
    public partial class StaffCompensation
    {
        public int StaffCompensationId { get; set; }

        public int StaffEmploymentId { get; set; }

        public decimal? StaffCompensationAnnualSupplement { get; set; }

        public decimal? StaffCompensationBaseSalary { get; set; }

        public decimal? StaffCompensationHealthBenefits { get; set; }

        public decimal? StaffCompensationLongevity { get; set; }

        public decimal? StaffCompensationOtherBenefits { get; set; }

        public decimal? StaffCompensationRetirementBenefits { get; set; }

        public decimal? StaffCompensationTotalBenefits { get; set; }

        public decimal? StaffCompensationTotalSalary { get; set; }

        public int? RefStaffCompensationSourceTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefStaffCompensationSourceType RefStaffCompensationSourceType { get; set; }

        public virtual StaffEmployment StaffEmployment { get; set; }
    }
}
