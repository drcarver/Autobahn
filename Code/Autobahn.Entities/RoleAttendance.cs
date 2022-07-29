using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RoleAttendance")]
    public partial class RoleAttendance
    {
        public int RoleAttendanceId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? NumberOfDaysInAttendance { get; set; }

        public decimal? NumberOfDaysAbsent { get; set; }

        public decimal? AttendanceRate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public decimal? NumberOfDaysTardy { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
