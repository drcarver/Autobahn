//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendance.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleAttendance
     /// </summary>
    public partial class RoleAttendance : AutobahnBase, Interfaces.IRoleAttendance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysInAttendance nullable property
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysAbsent nullable property
        /// </summary>
        public System.Decimal? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.AttendanceRate nullable property
        /// </summary>
        public System.Decimal? AttendanceRate { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysTardy nullable property
        /// </summary>
        public System.Decimal? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
