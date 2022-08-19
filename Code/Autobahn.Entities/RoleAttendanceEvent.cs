using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RoleAttendanceEvent")]
    public partial class RoleAttendanceEvent
    {
        public int RoleAttendanceEventId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? RefAttendanceEventTypeId { get; set; }

        public int? RefAttendanceStatusId { get; set; }

        public int? RefAbsentAttendanceCategoryId { get; set; }

        public int? RefPresentAttendanceCategoryId { get; set; }

        public int? RefLeaveEventTypeId { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAbsentAttendanceCategory RefAbsentAttendanceCategory { get; set; }

        public virtual RefAttendanceEventType RefAttendanceEventType { get; set; }

        public virtual RefAttendanceStatus RefAttendanceStatus { get; set; }

        public virtual RefLeaveEventType RefLeaveEventType { get; set; }

        public virtual RefPresentAttendanceCategory RefPresentAttendanceCategory { get; set; }
    }
}
