//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStaffViewModel
     /// </summary>
    public partial class AeStaffViewModel : ViewModelBase, Interfaces.IAeStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStaff";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAeStaffClassificationId property
        private Guid? _RefAeStaffClassificationId;

        // member variable for the RefAeStaffEmploymentStatusId property
        private  _RefAeStaffEmploymentStatusId;

        // member variable for the YearsOfPriorAeTeachingExperience property
        private  _YearsOfPriorAeTeachingExperience;

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
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get => _RefAeStaffClassificationId; set => SetProperty(ref _RefAeStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        public  RefAeStaffEmploymentStatusId { get => _RefAeStaffEmploymentStatusId; set => SetProperty(ref _RefAeStaffEmploymentStatusId, value); }

        /// <summary>
        /// </summary>
        public  YearsOfPriorAeTeachingExperience { get => _YearsOfPriorAeTeachingExperience; set => SetProperty(ref _YearsOfPriorAeTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAeStaffClassificationId = model.RefAeStaffClassificationId; // 
            RefAeStaffEmploymentStatusId = model.RefAeStaffEmploymentStatusId; // 
            YearsOfPriorAeTeachingExperience = model.YearsOfPriorAeTeachingExperience; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
