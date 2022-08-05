//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarSessionViewModel.cs
//**********************************************************


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

        // member variable for the Designator property
        private System.String _Designator;

        // member variable for the BeginDate property
        private System.DateTime? _BeginDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the RefSessionTypeId property
        private Guid? _RefSessionTypeId;

        // member variable for the InstructionalMinutes property
        private System.Decimal? _InstructionalMinutes;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the MarkingTermIndicator property
        private System.Boolean? _MarkingTermIndicator;

        // member variable for the SchedulingTermIndicator property
        private System.Boolean? _SchedulingTermIndicator;

        // member variable for the AttendanceTermIndicator property
        private System.Boolean? _AttendanceTermIndicator;

        // member variable for the OrganizationCalendarId property
        private Guid? _OrganizationCalendarId;

        // member variable for the DaysInSession property
        private System.Int32? _DaysInSession;

        // member variable for the FirstInstructionDate property
        private System.DateTime? _FirstInstructionDate;

        // member variable for the LastInstructionDate property
        private System.DateTime? _LastInstructionDate;

        // member variable for the MinutesPerDay property
        private System.Int32? _MinutesPerDay;

        // member variable for the SessionStartTime property
        private System.TimeSpan? _SessionStartTime;

        // member variable for the SessionEndTime property
        private System.TimeSpan? _SessionEndTime;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefAcademicTermDesignatorId property
        private Guid? _RefAcademicTermDesignatorId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Designator  { get => _Designator; set => SetProperty(ref _Designator, value); }

        public System.DateTime? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionTypeId"/> model
        /// </summary>
        public Guid? RefSessionTypeId { get => _RefSessionTypeId; set => SetProperty(ref _RefSessionTypeId, value); }

        public System.Decimal? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.Boolean? MarkingTermIndicator { get => _MarkingTermIndicator; set => SetProperty(ref _MarkingTermIndicator, value); }

        public System.Boolean? SchedulingTermIndicator { get => _SchedulingTermIndicator; set => SetProperty(ref _SchedulingTermIndicator, value); }

        public System.Boolean? AttendanceTermIndicator { get => _AttendanceTermIndicator; set => SetProperty(ref _AttendanceTermIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarId"/> model
        /// </summary>
        public Guid? OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        public System.Int32? DaysInSession { get => _DaysInSession; set => SetProperty(ref _DaysInSession, value); }

        public System.DateTime? FirstInstructionDate { get => _FirstInstructionDate; set => SetProperty(ref _FirstInstructionDate, value); }

        public System.DateTime? LastInstructionDate { get => _LastInstructionDate; set => SetProperty(ref _LastInstructionDate, value); }

        public System.Int32? MinutesPerDay { get => _MinutesPerDay; set => SetProperty(ref _MinutesPerDay, value); }

        public System.TimeSpan? SessionStartTime { get => _SessionStartTime; set => SetProperty(ref _SessionStartTime, value); }

        public System.TimeSpan? SessionEndTime { get => _SessionEndTime; set => SetProperty(ref _SessionEndTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignatorId"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarSession model)
        {
            IsBusy = true;
            Id = model.Id;
            Designator = model.Designator;
            BeginDate = model.BeginDate;
            EndDate = model.EndDate;
            RefSessionTypeId = model.RefSessionTypeId;
            InstructionalMinutes = model.InstructionalMinutes;
            Code = model.Code;
            Description = model.Description;
            MarkingTermIndicator = model.MarkingTermIndicator;
            SchedulingTermIndicator = model.SchedulingTermIndicator;
            AttendanceTermIndicator = model.AttendanceTermIndicator;
            OrganizationCalendarId = model.OrganizationCalendarId;
            DaysInSession = model.DaysInSession;
            FirstInstructionDate = model.FirstInstructionDate;
            LastInstructionDate = model.LastInstructionDate;
            MinutesPerDay = model.MinutesPerDay;
            SessionStartTime = model.SessionStartTime;
            SessionEndTime = model.SessionEndTime;
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
