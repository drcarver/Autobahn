//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarSession.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarSession
     /// </summary>
    public partial class OrganizationCalendarSession : IOrganizationCalendarSession
    {
        /// <summary>
        /// Defines the OrganizationCalendarSession.Designator non nullable property
        /// </summary>
        public System.String Designator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.BeginDate nullable property
        /// </summary>
        public System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionType"/> model
        /// </summary>
        public Guid? RefSessionTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.InstructionalMinutes nullable property
        /// </summary>
        public System.Decimal? InstructionalMinutes { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.MarkingTermIndicator nullable property
        /// </summary>
        public System.Boolean? MarkingTermIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SchedulingTermIndicator nullable property
        /// </summary>
        public System.Boolean? SchedulingTermIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.AttendanceTermIndicator nullable property
        /// </summary>
        public System.Boolean? AttendanceTermIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid? OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.DaysInSession nullable property
        /// </summary>
        public System.Int32? DaysInSession { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.FirstInstructionDate nullable property
        /// </summary>
        public System.DateTime? FirstInstructionDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.LastInstructionDate nullable property
        /// </summary>
        public System.DateTime? LastInstructionDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.MinutesPerDay nullable property
        /// </summary>
        public System.Int32? MinutesPerDay { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SessionStartTime nullable property
        /// </summary>
        public System.TimeSpan? SessionStartTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.SessionEndTime nullable property
        /// </summary>
        public System.TimeSpan? SessionEndTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarSession.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
