//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarSessionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarSessionViewModel
     /// </summary>
    public partial class OrganizationCalendarSessionViewModel : BindableBase, IOrganizationCalendarSession
    {
#region "Backing Fields"
        // member variable for the Designator property
        private System.String _Designator;

        // member variable for the BeginDate property
        private System.DateTime? _BeginDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

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

#endregion

#region Properties
        public System.String Designator  { get => _Designator; set => SetProperty(ref _Designator, value); }

        public System.DateTime? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSessionTypeId"/> model
        /// </summary>
        public Guid? RefSessionTypeId { get; set; }

        public System.Decimal? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.Boolean? MarkingTermIndicator { get => _MarkingTermIndicator; set => SetProperty(ref _MarkingTermIndicator, value); }

        public System.Boolean? SchedulingTermIndicator { get => _SchedulingTermIndicator; set => SetProperty(ref _SchedulingTermIndicator, value); }

        public System.Boolean? AttendanceTermIndicator { get => _AttendanceTermIndicator; set => SetProperty(ref _AttendanceTermIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarId"/> model
        /// </summary>
        public Guid? OrganizationCalendarId { get; set; }

        public System.Int32? DaysInSession { get => _DaysInSession; set => SetProperty(ref _DaysInSession, value); }

        public System.DateTime? FirstInstructionDate { get => _FirstInstructionDate; set => SetProperty(ref _FirstInstructionDate, value); }

        public System.DateTime? LastInstructionDate { get => _LastInstructionDate; set => SetProperty(ref _LastInstructionDate, value); }

        public System.Int32? MinutesPerDay { get => _MinutesPerDay; set => SetProperty(ref _MinutesPerDay, value); }

        public System.TimeSpan? SessionStartTime { get => _SessionStartTime; set => SetProperty(ref _SessionStartTime, value); }

        public System.TimeSpan? SessionEndTime { get => _SessionEndTime; set => SetProperty(ref _SessionEndTime, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignatorId"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IOrganizationCalendarSession model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
