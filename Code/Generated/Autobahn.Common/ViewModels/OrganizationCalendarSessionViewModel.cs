//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionViewModel.cs
//* Name:       Session Attendance Term Indicator
//* Definition: Indicates that the session is an attendance term.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// Indicates that the session is an attendance term.
     /// </summary>
    public partial class OrganizationCalendarSessionViewModel : ViewModelBase, Interfaces.IOrganizationCalendarSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarSession";

        // AttendanceTermIndicator -- (backing property for Session Attendance Term Indicator)
        private System.Boolean? _AttendanceTermIndicator;

        // BeginDate -- (backing property for Course Begin Date)
        private System.DateTime? _BeginDate;

        // DaysInSession -- (backing property for Days in Session)
        private System.Int32? _DaysInSession;

        // Designator -- (backing property for Session Designator)
        private System.String _Designator;

        // EndDate -- (backing property for Course End Date)
        private System.DateTime? _EndDate;

        // FirstInstructionDate -- (backing property for First Instruction Date)
        private System.DateTime? _FirstInstructionDate;

        // InstructionalMinutes -- (backing property for School Year Minutes)
        private System.Decimal? _InstructionalMinutes;

        // LastInstructionDate -- (backing property for Last Instruction Date)
        private System.DateTime? _LastInstructionDate;

        // MarkingTermIndicator -- (backing property for Session Marking Term Indicator)
        private System.Boolean? _MarkingTermIndicator;

        // MinutesPerDay -- (backing property for Minutes Per Day)
        private System.Int32? _MinutesPerDay;

        // member variable for the OrganizationCalendarId property
        private Guid? _OrganizationCalendarId;

        // RefAcademicTermDesignatorId -- (backing property for Academic Term Designator)
        private Guid? _RefAcademicTermDesignatorId;

        // RefSessionTypeId -- (backing property for Session Type)
        private Guid? _RefSessionTypeId;

        // SchedulingTermIndicator -- (backing property for Session Scheduling Term Indicator)
        private System.Boolean? _SchedulingTermIndicator;

        // SessionEndTime -- (backing property for Session End Time)
        private System.TimeSpan? _SessionEndTime;

        // SessionStartTime -- (backing property for Session Start Time)
        private System.TimeSpan? _SessionStartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AttendanceTermIndicator { get => _AttendanceTermIndicator; set => SetProperty(ref _AttendanceTermIndicator, value); }

        /// <summary>
        /// Course Begin Date
        /// <para>
        /// The year, month and day an instance of a course officially began.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        /// <summary>
        /// Days in Session
        /// <para>
        /// The total number of days that the school was or is anticipated to be in session during the school year. Also included are days on which the education institution facility is closed and the student body as a whole is engaged in planned activities off-campus under the guidance and direction of staff members.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19487">Days in Session</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? DaysInSession { get => _DaysInSession; set => SetProperty(ref _DaysInSession, value); }

        /// <summary>
        /// Session Designator
        /// <para>
        /// The academic session for which the data are recorded and applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19252">Session Designator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Designator { get => _Designator; set => SetProperty(ref _Designator, value); }

        /// <summary>
        /// Course End Date
        /// <para>
        /// The year, month and day an instance of a course ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19059">Course End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// First Instruction Date
        /// <para>
        /// The year, month and day of the first day of student instruction for the school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19488">First Instruction Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FirstInstructionDate { get => _FirstInstructionDate; set => SetProperty(ref _FirstInstructionDate, value); }

        /// <summary>
        /// School Year Minutes
        /// <para>
        /// The number of minutes that all students were required to be at school and any additional learning time (e.g., before or after school, weekend school, summer school) for which all students had the opportunity to participate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19244">School Year Minutes</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// Last Instruction Date
        /// <para>
        /// The year, month and day of the last day of student instruction (including days or times that students are present for purposes of testing and/or evaluation, but not including whole or part-days whose sole purposes is for distribution of report cards).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19489">Last Instruction Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? LastInstructionDate { get => _LastInstructionDate; set => SetProperty(ref _LastInstructionDate, value); }

        /// <summary>
        /// Session Marking Term Indicator
        /// <para>
        /// Indicates that the session is a marking term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20238">Session Marking Term Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? MarkingTermIndicator { get => _MarkingTermIndicator; set => SetProperty(ref _MarkingTermIndicator, value); }

        /// <summary>
        /// Minutes Per Day
        /// <para>
        /// The number of minutes in the day in which the school is normally in session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19491">Minutes Per Day</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? MinutesPerDay { get => _MinutesPerDay; set => SetProperty(ref _MinutesPerDay, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
        /// </summary>
        public Guid? OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        /// <summary>
        /// Academic Term Designator
        /// <para>
        /// The academic term for which the data apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19703">Academic Term Designator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Session Type
        /// <para>
        /// A prescribed span of time when an education institution is open, instruction is provided, and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19254">Session Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSessionTypeId { get => _RefSessionTypeId; set => SetProperty(ref _RefSessionTypeId, value); }

        /// <summary>
        /// Session Scheduling Term Indicator
        /// <para>
        /// Indicates that the session is a scheduling term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20239">Session Scheduling Term Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SchedulingTermIndicator { get => _SchedulingTermIndicator; set => SetProperty(ref _SchedulingTermIndicator, value); }

        /// <summary>
        /// Session End Time
        /// <para>
        /// The hour, minute and second on which a session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19988">Session End Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? SessionEndTime { get => _SessionEndTime; set => SetProperty(ref _SessionEndTime, value); }

        /// <summary>
        /// Session Start Time
        /// <para>
        /// The hour, minute and second on which a session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19986">Session Start Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? SessionStartTime { get => _SessionStartTime; set => SetProperty(ref _SessionStartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarSession model)
        {
            IsBusy = true;
            Id = model.Id;
            AttendanceTermIndicator = model.AttendanceTermIndicator; // Session Attendance Term Indicator
            BeginDate = model.BeginDate; // Course Begin Date
            DaysInSession = model.DaysInSession; // Days in Session
            Designator = model.Designator; // Session Designator
            EndDate = model.EndDate; // Course End Date
            FirstInstructionDate = model.FirstInstructionDate; // First Instruction Date
            InstructionalMinutes = model.InstructionalMinutes; // School Year Minutes
            LastInstructionDate = model.LastInstructionDate; // Last Instruction Date
            MarkingTermIndicator = model.MarkingTermIndicator; // Session Marking Term Indicator
            MinutesPerDay = model.MinutesPerDay; // Minutes Per Day
            OrganizationCalendarId = model.OrganizationCalendarId; // 
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // Academic Term Designator
            RefSessionTypeId = model.RefSessionTypeId; // Session Type
            SchedulingTermIndicator = model.SchedulingTermIndicator; // Session Scheduling Term Indicator
            SessionEndTime = model.SessionEndTime; // Session End Time
            SessionStartTime = model.SessionStartTime; // Session Start Time
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSessionType List
        /// <summary>
        /// The complete Session Attendance Term Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefSessionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0e5e3035-164d-4562-9109-aae4fa04172e"), Code="FullSchoolYear", Description="Full School Year", Definition="A regular school term consisting of no major subdivision of time segments. It usually begins in the late summer or early fall and ends in late spring or early summer (e.g., elementary school).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("38ab26b5-0b15-404c-ab91-a44f744a9a67"), Code="Intersession", Description="Intersession", Definition="A short session which occurs between longer sessions.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e7172149-eee5-4b85-b82a-2912732f9984"), Code="LongSession", Description="Long Session", Definition="A session that is longer than a semester but shorter than a full year.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e20f27b6-6ea8-4811-899f-56665ab3f89e"), Code="MiniTerm", Description="Mini Term", Definition="A school term which is shorter than a regular session.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("cda451bc-f04a-4a57-9730-4e9809ff348b"), Code="Quarter", Description="Quarter", Definition="One of four equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("84762eb0-39cd-4ab2-804f-7d609ac179b0"), Code="Quinmester", Description="Quinmester", Definition="One of five equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("bde7f99e-4ea8-421f-938b-3202b9970035"), Code="Semester", Description="Semester", Definition="One of two equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("edfa2e83-7d40-4785-860b-b636f595b367"), Code="SummerTerm", Description="Summer Term", Definition="A school term which takes place in the summer between two regular school terms.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("d9efc418-c446-4e92-9bc8-46f40814ca1e"), Code="Trimester", Description="Trimester", Definition="One of three equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("d0e9f82c-937f-42b6-b1ff-93c2f19cb72c"), Code="TwelveMonth", Description="Twelve Month", Definition="An educational program that operates on a full twelve month cycle.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("7c944cd0-3252-411d-8a15-657a6f2b6d0d"), Code="Other", Description="Other", Definition="The session type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("11.00") },
        };
        #endregion
    }
}
