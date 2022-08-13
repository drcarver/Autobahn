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
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Boolean? AttendanceTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Int32? DaysInSession { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.String Designator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.DateTime? FirstInstructionDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Decimal? InstructionalMinutes { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.DateTime? LastInstructionDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Boolean? MarkingTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Int32? MinutesPerDay { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        Guid? OrganizationCalendarId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        Guid? RefSessionTypeId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.Boolean? SchedulingTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.TimeSpan? SessionEndTime { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.TimeSpan? SessionStartTime { get; set; }

    }
}
