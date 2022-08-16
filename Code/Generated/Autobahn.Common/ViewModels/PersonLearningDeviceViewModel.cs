//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonLearningDeviceViewModel
     /// </summary>
    public partial class PersonLearningDeviceViewModel : ViewModelBase, Interfaces.IPersonLearningDevice
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonLearningDevice";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefPrimaryLearningDeviceAccessId property
        private  _RefPrimaryLearningDeviceAccessId;

        // member variable for the RefPrimaryLearningDeviceAwayFromSchoolId property
        private  _RefPrimaryLearningDeviceAwayFromSchoolId;

        // member variable for the RefPrimaryLearningDeviceProviderId property
        private  _RefPrimaryLearningDeviceProviderId;

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
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAccess"/> model
        /// </summary>
        public  RefPrimaryLearningDeviceAccessId { get => _RefPrimaryLearningDeviceAccessId; set => SetProperty(ref _RefPrimaryLearningDeviceAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAwayFromSchool"/> model
        /// </summary>
        public  RefPrimaryLearningDeviceAwayFromSchoolId { get => _RefPrimaryLearningDeviceAwayFromSchoolId; set => SetProperty(ref _RefPrimaryLearningDeviceAwayFromSchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceProvider"/> model
        /// </summary>
        public  RefPrimaryLearningDeviceProviderId { get => _RefPrimaryLearningDeviceProviderId; set => SetProperty(ref _RefPrimaryLearningDeviceProviderId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLearningDevice model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPrimaryLearningDeviceAccessId = model.RefPrimaryLearningDeviceAccessId; // 
            RefPrimaryLearningDeviceAwayFromSchoolId = model.RefPrimaryLearningDeviceAwayFromSchoolId; // 
            RefPrimaryLearningDeviceProviderId = model.RefPrimaryLearningDeviceProviderId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
