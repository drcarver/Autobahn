//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityRecognitionViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ActivityRecognitionViewModel
     /// </summary>
    public partial class ActivityRecognitionViewModel : ViewModelBase, Interfaces.IActivityRecognition
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ActivityRecognition";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefActivityRecognitionTypeId property
        private Guid _RefActivityRecognitionTypeId;

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
        /// The title of the ActivityRecognitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefActivityRecognitionTypeId"/> model
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get => _RefActivityRecognitionTypeId; set => SetProperty(ref _RefActivityRecognitionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivityRecognition model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefActivityRecognitionTypeId = model.RefActivityRecognitionTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
