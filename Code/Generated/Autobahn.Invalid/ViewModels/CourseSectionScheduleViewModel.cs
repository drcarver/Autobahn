//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionScheduleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _ClassBeginningTime;

        // member variable for the ClassEndingTime property
        private  _ClassEndingTime;

        // member variable for the ClassMeetingDays property
        private  _ClassMeetingDays;

        // member variable for the ClassPeriod property
        private  _ClassPeriod;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the TimeDayIdentifier property
        private  _TimeDayIdentifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        /// <summary>
        /// </summary>
        public  ClassEndingTime { get => _ClassEndingTime; set => SetProperty(ref _ClassEndingTime, value); }

        /// <summary>
        /// </summary>
        public  ClassMeetingDays { get => _ClassMeetingDays; set => SetProperty(ref _ClassMeetingDays, value); }

        /// <summary>
        /// </summary>
        public  ClassPeriod { get => _ClassPeriod; set => SetProperty(ref _ClassPeriod, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  TimeDayIdentifier { get => _TimeDayIdentifier; set => SetProperty(ref _TimeDayIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassBeginningTime = model.ClassBeginningTime; // 
            ClassEndingTime = model.ClassEndingTime; // 
            ClassMeetingDays = model.ClassMeetingDays; // 
            ClassPeriod = model.ClassPeriod; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            TimeDayIdentifier = model.TimeDayIdentifier; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
