//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceEvent.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleAttendanceEvent
     /// </summary>
    public partial class RoleAttendanceEvent : AutobahnBase, Interfaces.IRoleAttendanceEvent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.Date non nullable property
        /// </summary>
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventType"/> model
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventType"/> model
        /// </summary>
        public Guid? RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.StartTime nullable property
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the RoleAttendanceEvent.EndTime nullable property
        /// </summary>
        public System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
