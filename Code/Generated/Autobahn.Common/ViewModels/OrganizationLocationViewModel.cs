//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationLocationViewModel
     /// </summary>
    public partial class OrganizationLocationViewModel : ViewModelBase, Interfaces.IOrganizationLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationLocation";

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationLocationTypeId property
        private Guid? _RefOrganizationLocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationType"/> model
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
            LocationId = model.LocationId;
            OrganizationId = model.OrganizationId;
            RefOrganizationLocationTypeId = model.RefOrganizationLocationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
