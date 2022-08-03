//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionScheduleViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionScheduleViewModel
     /// </summary>
    public partial class CourseSectionScheduleViewModel : BindableBase, ICourseSectionSchedule
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        public System.String ClassMeetingDays  { get => _ClassMeetingDays; set => SetProperty(ref _ClassMeetingDays, value); }

        public System.TimeSpan? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        public System.TimeSpan? ClassEndingTime { get => _ClassEndingTime; set => SetProperty(ref _ClassEndingTime, value); }

        public System.String ClassPeriod  { get => _ClassPeriod; set => SetProperty(ref _ClassPeriod, value); }

        public System.String TimeDayIdentifier  { get => _TimeDayIdentifier; set => SetProperty(ref _TimeDayIdentifier, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            ClassMeetingDays = model.ClassMeetingDays;
            ClassBeginningTime = model.ClassBeginningTime;
            ClassEndingTime = model.ClassEndingTime;
            ClassPeriod = model.ClassPeriod;
            TimeDayIdentifier = model.TimeDayIdentifier;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
