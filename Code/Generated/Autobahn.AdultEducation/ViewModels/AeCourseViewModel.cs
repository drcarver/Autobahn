//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeCourseViewModel
     /// </summary>
    public partial class AeCourseViewModel : ViewModelBase, Interfaces.IAeCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeCourse";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCareerClusterId property
        private Guid? _RefCareerClusterId;

        // member variable for the RefCourseLevelTypeId property
        private  _RefCourseLevelTypeId;

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
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public  RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCareerClusterId = model.RefCareerClusterId; // 
            RefCourseLevelTypeId = model.RefCourseLevelTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
