//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleAttendanceEvent.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendanceEvent
     /// </summary>
    public partial interface IRoleAttendanceEvent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.Date non nullable property
        /// </summary>
        System.DateTime Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventType"/> model
        /// </summary>
        Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategory"/> model
        /// </summary>
        Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategory"/> model
        /// </summary>
        Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventType"/> model
        /// </summary>
        Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.StartTime nullable property
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.EndTime nullable property
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

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
