//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleAttendance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendance Interface
     /// </summary>
    public partial interface IRoleAttendance : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AttendanceRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfDaysTardy { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
