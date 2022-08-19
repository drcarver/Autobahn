using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffExperience")]
    public partial class StaffExperience
    {
        public int StaffExperienceId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? YearsOfPriorTeachingExperience { get; set; }

        public decimal? YearsOfPriorAETeachingExperience { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
