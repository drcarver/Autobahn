using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELOrganizationAvailability")]
    public partial class ELOrganizationAvailability
    {
        public int ELOrganizationAvailabilityId { get; set; }

        public int OrganizationId { get; set; }

        public int? DaysAvailablePerWeek { get; set; }

        public decimal? HoursAvailablePerDay { get; set; }

        public int? NumberOfClassrooms { get; set; }

        public int? AnnualOperatingWeeks { get; set; }

        public int? RefEnvironmentSettingId { get; set; }

        public int? RefServiceOptionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEnvironmentSetting RefEnvironmentSetting { get; set; }

        public virtual RefServiceOption RefServiceOption { get; set; }
    }
}
