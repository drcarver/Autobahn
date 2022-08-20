using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationCalendarDay")]
    public partial class OrganizationCalendarDay
    {
        public int OrganizationCalendarDayId { get; set; }

        public int OrganizationCalendarId { get; set; }

        [Required]
        [StringLength(30)]
        public string DayName { get; set; }

        [StringLength(30)]
        public string AlternateDayName { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationCalendar OrganizationCalendar { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
