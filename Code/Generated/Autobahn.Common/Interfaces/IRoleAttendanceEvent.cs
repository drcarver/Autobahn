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
        /// 
        /// </summary>
         Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLeaveEventTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartTime { get; set; }

    }
}
