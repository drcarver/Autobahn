//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleAttendanceEvent.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendanceEvent Interface
     /// </summary>
    public partial interface IRoleAttendanceEvent : IAutobahnBase
    {
        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        System.DateTime Date { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

    }
}