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
        public Guid? RefAttendanceStatusId { get; set; }

    }
}
