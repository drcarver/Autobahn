//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetailViewModel
     /// </summary>
    public partial class OrganizationDetailViewModel : ViewModelBase, Interfaces.IOrganizationDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationDetail";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationTypeId property
        private Guid? _RefOrganizationTypeId;

        // member variable for the RegionGeoJSON property
        private System.String _RegionGeoJSON;

        // member variable for the ShortName property
        private System.String _ShortName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationDetailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get => _RefOrganizationTypeId; set => SetProperty(ref _RefOrganizationTypeId, value); }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String RegionGeoJSON { get => _RegionGeoJSON; set => SetProperty(ref _RegionGeoJSON, value); }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            OrganizationId = model.OrganizationId;
            RefOrganizationTypeId = model.RefOrganizationTypeId;
            RegionGeoJSON = model.RegionGeoJSON;
            ShortName = model.ShortName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
