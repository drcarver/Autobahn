//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleAttendanceEvent Model
     /// </summary>
    public partial class RoleAttendanceEventModel : AutobahnBase, Interfaces.IRoleAttendanceEvent
    {
        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.DateTime Date { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

    }
}
