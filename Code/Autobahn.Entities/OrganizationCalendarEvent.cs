using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationCalendarEvent")]
    public partial class OrganizationCalendarEvent
    {
        public int OrganizationCalendarEventId { get; set; }

        public int OrganizationCalendarId { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }

        public int? RefCalendarEventType { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationCalendar OrganizationCalendar { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCalendarEventType RefCalendarEventType1 { get; set; }
    }
}
