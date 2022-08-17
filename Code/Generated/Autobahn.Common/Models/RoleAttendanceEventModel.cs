//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RoleAttendanceEvent Model
     /// </summary>
    public partial class RoleAttendanceEventModel : AutobahnBase, Interfaces.IRoleAttendanceEvent
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
        public System.DateTime Date { get; set; }

        /// <summary>
        /// End Time
        /// <para>
        /// The ending hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAbsentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAttendanceEventType"/> model
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAttendanceStatus"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaveEventType"/> model
        /// </summary>
        public Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPresentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

    }
}
