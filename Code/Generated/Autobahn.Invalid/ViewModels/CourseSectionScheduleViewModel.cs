//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionScheduleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionScheduleViewModel
     /// </summary>
    public partial class CourseSectionScheduleViewModel : ViewModelBase, Interfaces.ICourseSectionSchedule
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionSchedule";

        // member variable for the ClassBeginningTime property
        private System.TimeSpan? _ClassBeginningTime;

        // member variable for the ClassEndingTime property
        private System.TimeSpan? _ClassEndingTime;

        // member variable for the ClassMeetingDays property
        private System.String _ClassMeetingDays;

        // member variable for the ClassPeriod property
        private System.String _ClassPeriod;

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // member variable for the TimeDayIdentifier property
        private System.String _TimeDayIdentifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionScheduleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.TimeSpan? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.TimeSpan? ClassEndingTime { get => _ClassEndingTime; set => SetProperty(ref _ClassEndingTime, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.String ClassMeetingDays { get => _ClassMeetingDays; set => SetProperty(ref _ClassMeetingDays, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.String ClassPeriod { get => _ClassPeriod; set => SetProperty(ref _ClassPeriod, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.String TimeDayIdentifier { get => _TimeDayIdentifier; set => SetProperty(ref _TimeDayIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassBeginningTime = model.ClassBeginningTime;
            ClassEndingTime = model.ClassEndingTime;
            ClassMeetingDays = model.ClassMeetingDays;
            ClassPeriod = model.ClassPeriod;
            CourseSectionId = model.CourseSectionId;
            TimeDayIdentifier = model.TimeDayIdentifier;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
