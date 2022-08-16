//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffExperienceViewModel
     /// </summary>
    public partial class StaffExperienceViewModel : ViewModelBase, Interfaces.IStaffExperience
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffExperience";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the YearsOfPriorAETeachingExperience property
        private  _YearsOfPriorAETeachingExperience;

        // member variable for the YearsOfPriorTeachingExperience property
        private Guid? _YearsOfPriorTeachingExperience;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  YearsOfPriorAETeachingExperience { get => _YearsOfPriorAETeachingExperience; set => SetProperty(ref _YearsOfPriorAETeachingExperience, value); }

        /// <summary>
        /// </summary>
        public Guid? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            YearsOfPriorAETeachingExperience = model.YearsOfPriorAETeachingExperience; // 
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
