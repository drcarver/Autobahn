//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleAttendance.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendance
     /// </summary>
    public partial interface IRoleAttendance
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
        /// Defines the RoleAttendance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendance.NumberOfDaysTardy nullable property
        /// </summary>
        System.Decimal? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
