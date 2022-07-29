using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AeStaff")]
    public partial class AeStaff
    {
        public int AeStaffId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? YearsOfPriorAeTeachingExperience { get; set; }

        public int? RefAeStaffClassificationId { get; set; }

        public int? RefAeStaffEmploymentStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAeStaffClassification RefAeStaffClassification { get; set; }

        public virtual RefAeStaffEmploymentStatu RefAeStaffEmploymentStatu { get; set; }
    }
}
