//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonLearningDeviceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAccess"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get => _RefPrimaryLearningDeviceAccessId; set => SetProperty(ref _RefPrimaryLearningDeviceAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAwayFromSchool"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get => _RefPrimaryLearningDeviceAwayFromSchoolId; set => SetProperty(ref _RefPrimaryLearningDeviceAwayFromSchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceProvider"/> model
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
