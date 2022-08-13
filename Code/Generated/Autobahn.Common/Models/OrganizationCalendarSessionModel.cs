//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarSession Model
     /// </summary>
    public partial class OrganizationCalendarSessionModel : AutobahnBase, Interfaces.IOrganizationCalendarSession
    {
        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? AttendanceTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Int32? DaysInSession { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.String Designator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? FirstInstructionDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Decimal? InstructionalMinutes { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? LastInstructionDate { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? MarkingTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Int32? MinutesPerDay { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public Guid? OrganizationCalendarId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public Guid? RefSessionTypeId { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? SchedulingTermIndicator { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.TimeSpan? SessionEndTime { get; set; }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.TimeSpan? SessionStartTime { get; set; }

    }
}
