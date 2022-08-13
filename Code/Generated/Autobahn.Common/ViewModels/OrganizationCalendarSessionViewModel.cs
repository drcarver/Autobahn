//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarSessionViewModel
     /// </summary>
    public partial class OrganizationCalendarSessionViewModel : ViewModelBase, Interfaces.IOrganizationCalendarSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarSession";

        // member variable for the AttendanceTermIndicator property
        private System.Boolean? _AttendanceTermIndicator;

        // member variable for the BeginDate property
        private System.DateTime? _BeginDate;

        // member variable for the DaysInSession property
        private System.Int32? _DaysInSession;

        // member variable for the Designator property
        private System.String _Designator;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the FirstInstructionDate property
        private System.DateTime? _FirstInstructionDate;

        // member variable for the InstructionalMinutes property
        private System.Decimal? _InstructionalMinutes;

        // member variable for the LastInstructionDate property
        private System.DateTime? _LastInstructionDate;

        // member variable for the MarkingTermIndicator property
        private System.Boolean? _MarkingTermIndicator;

        // member variable for the MinutesPerDay property
        private System.Int32? _MinutesPerDay;

        // member variable for the OrganizationCalendarId property
        private Guid? _OrganizationCalendarId;

        // member variable for the RefAcademicTermDesignatorId property
        private Guid? _RefAcademicTermDesignatorId;

        // member variable for the RefSessionTypeId property
        private Guid? _RefSessionTypeId;

        // member variable for the SchedulingTermIndicator property
        private System.Boolean? _SchedulingTermIndicator;

        // member variable for the SessionEndTime property
        private System.TimeSpan? _SessionEndTime;

        // member variable for the SessionStartTime property
        private System.TimeSpan? _SessionStartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? AttendanceTermIndicator { get => _AttendanceTermIndicator; set => SetProperty(ref _AttendanceTermIndicator, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Int32? DaysInSession { get => _DaysInSession; set => SetProperty(ref _DaysInSession, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.String Designator { get => _Designator; set => SetProperty(ref _Designator, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? FirstInstructionDate { get => _FirstInstructionDate; set => SetProperty(ref _FirstInstructionDate, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Decimal? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? LastInstructionDate { get => _LastInstructionDate; set => SetProperty(ref _LastInstructionDate, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? MarkingTermIndicator { get => _MarkingTermIndicator; set => SetProperty(ref _MarkingTermIndicator, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Int32? MinutesPerDay { get => _MinutesPerDay; set => SetProperty(ref _MinutesPerDay, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid? OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionType"/> model
        /// </summary>
        public Guid? RefSessionTypeId { get => _RefSessionTypeId; set => SetProperty(ref _RefSessionTypeId, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.Boolean? SchedulingTermIndicator { get => _SchedulingTermIndicator; set => SetProperty(ref _SchedulingTermIndicator, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.TimeSpan? SessionEndTime { get => _SessionEndTime; set => SetProperty(ref _SessionEndTime, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
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
            AttendanceTermIndicator = model.AttendanceTermIndicator;
            BeginDate = model.BeginDate;
            DaysInSession = model.DaysInSession;
            Designator = model.Designator;
            EndDate = model.EndDate;
            FirstInstructionDate = model.FirstInstructionDate;
            InstructionalMinutes = model.InstructionalMinutes;
            LastInstructionDate = model.LastInstructionDate;
            MarkingTermIndicator = model.MarkingTermIndicator;
            MinutesPerDay = model.MinutesPerDay;
            OrganizationCalendarId = model.OrganizationCalendarId;
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId;
            RefSessionTypeId = model.RefSessionTypeId;
            SchedulingTermIndicator = model.SchedulingTermIndicator;
            SessionEndTime = model.SessionEndTime;
            SessionStartTime = model.SessionStartTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
