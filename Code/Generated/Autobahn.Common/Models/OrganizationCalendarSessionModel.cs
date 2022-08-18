//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionModel.cs
//* Name:       Session Attendance Term Indicator
//* Definition: Indicates that the session is an attendance term.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// Indicates that the session is an attendance term.
     /// </summary>
    public partial class OrganizationCalendarSessionModel : AutobahnBase, Interfaces.IOrganizationCalendarSession
    {
        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? AttendanceTermIndicator { get; set; }

        /// <summary>
        /// Course Begin Date
        /// <para>
        /// The year, month and day an instance of a course officially began.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// Days in Session
        /// <para>
        /// The total number of days that the school was or is anticipated to be in session during the school year. Also included are days on which the education institution facility is closed and the student body as a whole is engaged in planned activities off-campus under the guidance and direction of staff members.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19487">Days in Session</a>
        /// </para>
        /// </summary>
        public System.Int32? DaysInSession { get; set; }

        /// <summary>
        /// Session Designator
        /// <para>
        /// The academic session for which the data are recorded and applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19252">Session Designator</a>
        /// </para>
        /// </summary>
        public System.String Designator { get; set; }

        /// <summary>
        /// Course End Date
        /// <para>
        /// The year, month and day an instance of a course ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19059">Course End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// First Instruction Date
        /// <para>
        /// The year, month and day of the first day of student instruction for the school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19488">First Instruction Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? FirstInstructionDate { get; set; }

        /// <summary>
        /// School Year Minutes
        /// <para>
        /// The number of minutes that all students were required to be at school and any additional learning time (e.g., before or after school, weekend school, summer school) for which all students had the opportunity to participate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19244">School Year Minutes</a>
        /// </para>
        /// </summary>
        public System.Decimal? InstructionalMinutes { get; set; }

        /// <summary>
        /// Last Instruction Date
        /// <para>
        /// The year, month and day of the last day of student instruction (including days or times that students are present for purposes of testing and/or evaluation, but not including whole or part-days whose sole purposes is for distribution of report cards).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19489">Last Instruction Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? LastInstructionDate { get; set; }

        /// <summary>
        /// Session Marking Term Indicator
        /// <para>
        /// Indicates that the session is a marking term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20238">Session Marking Term Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? MarkingTermIndicator { get; set; }

        /// <summary>
        /// Minutes Per Day
        /// <para>
        /// The number of minutes in the day in which the school is normally in session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19491">Minutes Per Day</a>
        /// </para>
        /// </summary>
        public System.Int32? MinutesPerDay { get; set; }

        /// <summary>
        /// Calendar Code
        /// <para>
        /// A unique number assigned by a school district to a school calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
        /// </para>
        /// </summary>
        public Guid? OrganizationCalendarId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionType"/> model
        /// </summary>
        public Guid? RefSessionTypeId { get; set; }

        /// <summary>
        /// Session Scheduling Term Indicator
        /// <para>
        /// Indicates that the session is a scheduling term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20239">Session Scheduling Term Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? SchedulingTermIndicator { get; set; }

        /// <summary>
        /// Session End Time
        /// <para>
        /// The hour, minute and second on which a session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19988">Session End Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? SessionEndTime { get; set; }

        /// <summary>
        /// Session Start Time
        /// <para>
        /// The hour, minute and second on which a session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19986">Session Start Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? SessionStartTime { get; set; }

    }
}
