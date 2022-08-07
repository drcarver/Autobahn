//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleAttendanceEventModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendanceEventModel Interface
     /// </summary>
    public partial interface IRoleAttendanceEventModel : IAutobahnBase
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

    }
}
