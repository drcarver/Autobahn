//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionScheduleViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionScheduleViewModel
     /// </summary>
    public partial class CourseSectionScheduleViewModel : ViewModelBase, Interfaces.ICourseSectionScheduleViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionSchedule";

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // member variable for the ClassMeetingDays property
        private System.String _ClassMeetingDays;

        // member variable for the ClassBeginningTime property
        private System.TimeSpan? _ClassBeginningTime;

        // member variable for the ClassEndingTime property
        private System.TimeSpan? _ClassEndingTime;

        // member variable for the ClassPeriod property
        private System.String _ClassPeriod;

        // member variable for the TimeDayIdentifier property
        private System.String _TimeDayIdentifier;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionScheduleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        public System.String ClassMeetingDays  { get => _ClassMeetingDays; set => SetProperty(ref _ClassMeetingDays, value); }

        public System.TimeSpan? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        public System.TimeSpan? ClassEndingTime { get => _ClassEndingTime; set => SetProperty(ref _ClassEndingTime, value); }

        public System.String ClassPeriod  { get => _ClassPeriod; set => SetProperty(ref _ClassPeriod, value); }

        public System.String TimeDayIdentifier  { get => _TimeDayIdentifier; set => SetProperty(ref _TimeDayIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            ClassMeetingDays = model.ClassMeetingDays;
            ClassBeginningTime = model.ClassBeginningTime;
            ClassEndingTime = model.ClassEndingTime;
            ClassPeriod = model.ClassPeriod;
            TimeDayIdentifier = model.TimeDayIdentifier;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
