//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AttendanceTermIndicator;

        // member variable for the BeginDate property
        private Guid? _BeginDate;

        // member variable for the Code property
        private  _Code;

        // member variable for the DaysInSession property
        private  _DaysInSession;

        // member variable for the Description property
        private  _Description;

        // member variable for the Designator property
        private  _Designator;

        // member variable for the EndDate property
        private  _EndDate;

        // member variable for the FirstInstructionDate property
        private  _FirstInstructionDate;

        // member variable for the InstructionalMinutes property
        private  _InstructionalMinutes;

        // member variable for the LastInstructionDate property
        private  _LastInstructionDate;

        // member variable for the MarkingTermIndicator property
        private  _MarkingTermIndicator;

        // member variable for the MinutesPerDay property
        private  _MinutesPerDay;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicTermDesignatorId property
        private  _RefAcademicTermDesignatorId;

        // member variable for the RefSessionTypeId property
        private  _RefSessionTypeId;

        // member variable for the SchedulingTermIndicator property
        private  _SchedulingTermIndicator;

        // member variable for the SessionEndTime property
        private  _SessionEndTime;

        // member variable for the SessionStartTime property
        private  _SessionStartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AttendanceTermIndicator { get => _AttendanceTermIndicator; set => SetProperty(ref _AttendanceTermIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        /// <summary>
        /// </summary>
        public  Code { get => _Code; set => SetProperty(ref _Code, value); }

        /// <summary>
        /// </summary>
        public  DaysInSession { get => _DaysInSession; set => SetProperty(ref _DaysInSession, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Designator { get => _Designator; set => SetProperty(ref _Designator, value); }

        /// <summary>
        /// </summary>
        public  EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// </summary>
        public  FirstInstructionDate { get => _FirstInstructionDate; set => SetProperty(ref _FirstInstructionDate, value); }

        /// <summary>
        /// </summary>
        public  InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// </summary>
        public  LastInstructionDate { get => _LastInstructionDate; set => SetProperty(ref _LastInstructionDate, value); }

        /// <summary>
        /// </summary>
        public  MarkingTermIndicator { get => _MarkingTermIndicator; set => SetProperty(ref _MarkingTermIndicator, value); }

        /// <summary>
        /// </summary>
        public  MinutesPerDay { get => _MinutesPerDay; set => SetProperty(ref _MinutesPerDay, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public  RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionType"/> model
        /// </summary>
        public  RefSessionTypeId { get => _RefSessionTypeId; set => SetProperty(ref _RefSessionTypeId, value); }

        /// <summary>
        /// </summary>
        public  SchedulingTermIndicator { get => _SchedulingTermIndicator; set => SetProperty(ref _SchedulingTermIndicator, value); }

        /// <summary>
        /// </summary>
        public  SessionEndTime { get => _SessionEndTime; set => SetProperty(ref _SessionEndTime, value); }

        /// <summary>
        /// </summary>
        public  SessionStartTime { get => _SessionStartTime; set => SetProperty(ref _SessionStartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarSession model)
        {
            IsBusy = true;
            Id = model.Id;
            AttendanceTermIndicator = model.AttendanceTermIndicator; // 
            BeginDate = model.BeginDate; // 
            Code = model.Code; // 
            DaysInSession = model.DaysInSession; // 
            Description = model.Description; // 
            Designator = model.Designator; // 
            EndDate = model.EndDate; // 
            FirstInstructionDate = model.FirstInstructionDate; // 
            InstructionalMinutes = model.InstructionalMinutes; // 
            LastInstructionDate = model.LastInstructionDate; // 
            MarkingTermIndicator = model.MarkingTermIndicator; // 
            MinutesPerDay = model.MinutesPerDay; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // 
            RefSessionTypeId = model.RefSessionTypeId; // 
            SchedulingTermIndicator = model.SchedulingTermIndicator; // 
            SessionEndTime = model.SessionEndTime; // 
            SessionStartTime = model.SessionStartTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
