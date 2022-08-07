//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarSessionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarSessionModel Interface
     /// </summary>
    public partial interface IOrganizationCalendarSessionModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the OrganizationCalendarSession.Designator non nullable property
        /// </summary>
        System.String Designator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.BeginDate nullable property
        /// </summary>
        System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionType"/> model
        /// </summary>
        Guid? RefSessionTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.InstructionalMinutes nullable property
        /// </summary>
        System.Decimal? InstructionalMinutes { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.MarkingTermIndicator nullable property
        /// </summary>
        System.Boolean? MarkingTermIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SchedulingTermIndicator nullable property
        /// </summary>
        System.Boolean? SchedulingTermIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.AttendanceTermIndicator nullable property
        /// </summary>
        System.Boolean? AttendanceTermIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        Guid? OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.DaysInSession nullable property
        /// </summary>
        System.Int32? DaysInSession { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.FirstInstructionDate nullable property
        /// </summary>
        System.DateTime? FirstInstructionDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.LastInstructionDate nullable property
        /// </summary>
        System.DateTime? LastInstructionDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.MinutesPerDay nullable property
        /// </summary>
        System.Int32? MinutesPerDay { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SessionStartTime nullable property
        /// </summary>
        System.TimeSpan? SessionStartTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SessionEndTime nullable property
        /// </summary>
        System.TimeSpan? SessionEndTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        Guid? RefAcademicTermDesignatorId { get; set; }

    }
}
