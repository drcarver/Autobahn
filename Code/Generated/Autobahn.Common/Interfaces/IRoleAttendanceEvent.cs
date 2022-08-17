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
        /// Attendance Event Date
        /// <para>
        /// The date on which an attendance event takes place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20630">Attendance Event Date</a>
        /// </para>
        /// </summary>
        System.DateTime Date { get; set; }

        /// <summary>
        /// End Time
        /// <para>
        /// The ending hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAbsentAttendanceCategory"/> model
        /// </summary>
        Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAttendanceEventType"/> model
        /// </summary>
        Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAttendanceStatus"/> model
        /// </summary>
        Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaveEventType"/> model
        /// </summary>
        Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPresentAttendanceCategory"/> model
        /// </summary>
        Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

    }
}
