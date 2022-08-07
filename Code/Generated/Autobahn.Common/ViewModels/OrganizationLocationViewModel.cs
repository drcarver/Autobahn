//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationLocationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationLocationViewModel
     /// </summary>
    public partial class OrganizationLocationViewModel : ViewModelBase, Interfaces.IOrganizationLocationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationLocation";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the RefOrganizationLocationTypeId property
        private Guid? _RefOrganizationLocationTypeId;

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
        /// The title of the OrganizationLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationTypeId"/> model
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get => _RefOrganizationLocationTypeId; set => SetProperty(ref _RefOrganizationLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            LocationId = model.LocationId;
            RefOrganizationLocationTypeId = model.RefOrganizationLocationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
