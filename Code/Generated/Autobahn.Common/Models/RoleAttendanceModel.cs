//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleAttendance Model
     /// </summary>
    public partial class RoleAttendanceModel : AutobahnBase, Interfaces.IRoleAttendance
    {
        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? AttendanceRate { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
