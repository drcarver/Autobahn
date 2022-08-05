//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLearningDeviceViewModel.cs
//**********************************************************


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

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefPrimaryLearningDeviceAccessId property
        private Guid? _RefPrimaryLearningDeviceAccessId;

        // member variable for the RefPrimaryLearningDeviceAwayFromSchoolId property
        private Guid? _RefPrimaryLearningDeviceAwayFromSchoolId;

        // member variable for the RefPrimaryLearningDeviceProviderId property
        private Guid? _RefPrimaryLearningDeviceProviderId;

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
        /// The title of the PersonLearningDeviceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAccessId"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get => _RefPrimaryLearningDeviceAccessId; set => SetProperty(ref _RefPrimaryLearningDeviceAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAwayFromSchoolId"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get => _RefPrimaryLearningDeviceAwayFromSchoolId; set => SetProperty(ref _RefPrimaryLearningDeviceAwayFromSchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceProviderId"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceProviderId { get => _RefPrimaryLearningDeviceProviderId; set => SetProperty(ref _RefPrimaryLearningDeviceProviderId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLearningDevice model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefPrimaryLearningDeviceAccessId = model.RefPrimaryLearningDeviceAccessId;
            RefPrimaryLearningDeviceAwayFromSchoolId = model.RefPrimaryLearningDeviceAwayFromSchoolId;
            RefPrimaryLearningDeviceProviderId = model.RefPrimaryLearningDeviceProviderId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
