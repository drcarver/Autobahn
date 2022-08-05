//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleAttendance.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendance
     /// </summary>
    public partial interface IRoleAttendance : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysInAttendance nullable property
        /// </summary>
        System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysAbsent nullable property
        /// </summary>
        System.Decimal? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.AttendanceRate nullable property
        /// </summary>
        System.Decimal? AttendanceRate { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysTardy nullable property
        /// </summary>
        System.Decimal? NumberOfDaysTardy { get; set; }

    }
}
