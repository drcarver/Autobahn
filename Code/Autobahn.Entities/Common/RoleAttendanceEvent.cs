//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceEvent.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RoleAttendanceEvent", Schema = "Common")]
    public partial class RoleAttendanceEvent : EntityBase
    {
        [ForeignKey("OrganizationPersonRole")]
        public Guid OrganizationPersonRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [ForeignKey("RefAttendanceEventType")]
        public Guid? RefAttendanceEventTypeId { get; set; }

        [ForeignKey("RefAttendanceStatus")]
        public Guid? RefAttendanceStatusId { get; set; }

        [ForeignKey("RefAbsentAttendanceCategory")]
        public Guid? RefAbsentAttendanceCategoryId { get; set; }

        [ForeignKey("RefPresentAttendanceCategory")]
        public Guid? RefPresentAttendanceCategoryId { get; set; }

        [ForeignKey("RefLeaveEventType")]
        public Guid? RefLeaveEventTypeId { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole1 { get; set; }

        public virtual RefAbsentAttendanceCategory RefAbsentAttendanceCategory { get; set; }

        public virtual RefAttendanceEventType RefAttendanceEventType { get; set; }

        public virtual RefAttendanceStatus RefAttendanceStatus { get; set; }

        public virtual RefLeaveEventType RefLeaveEventType { get; set; }

        public virtual RefPresentAttendanceCategory RefPresentAttendanceCategory { get; set; }
    }
}
