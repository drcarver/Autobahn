//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleAttendance Model
     /// </summary>
    public partial class RoleAttendanceModel : AutobahnBase, Interfaces.IRoleAttendance
    {
        /// <summary>
        /// 
        /// </summary>
        public  AttendanceRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfDaysTardy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
