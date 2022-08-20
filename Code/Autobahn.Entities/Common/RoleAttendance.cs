//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendance.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RoleAttendance", Schema = "Common")]
    public partial class RoleAttendance : EntityBase
    {
        [ForeignKey("OrganizationPersonRole")]
        public int OrganizationPersonRoleId { get; set; }

        public decimal? NumberOfDaysInAttendance { get; set; }

        public decimal? NumberOfDaysAbsent { get; set; }

        public decimal? AttendanceRate { get; set; }

        public decimal? NumberOfDaysTardy { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }
    }
}
