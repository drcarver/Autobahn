//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarSession.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarSession Interface
     /// </summary>
    public partial interface IOrganizationCalendarSession : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AttendanceTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? BeginDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DaysInSession { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Designator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstInstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstructionalMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LastInstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MarkingTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinutesPerDay { get; set; }

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
         RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchedulingTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SessionEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SessionStartTime { get; set; }

    }
}
