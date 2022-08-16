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
        /// 
        /// </summary>
        public  Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartTime { get; set; }

    }
}
