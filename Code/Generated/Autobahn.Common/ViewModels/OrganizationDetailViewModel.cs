//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationDetailViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetailViewModel
     /// </summary>
    public partial class OrganizationDetailViewModel : ViewModelBase, Interfaces.IOrganizationDetailViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationDetail";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the RegionGeoJSON property
        private System.String _RegionGeoJSON;

        // member variable for the RefOrganizationTypeId property
        private Guid? _RefOrganizationTypeId;

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
        /// The title of the OrganizationDetailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String ShortName  { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        public System.String RegionGeoJSON  { get => _RegionGeoJSON; set => SetProperty(ref _RegionGeoJSON, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get => _RefOrganizationTypeId; set => SetProperty(ref _RefOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            Name = model.Name;
            ShortName = model.ShortName;
            RegionGeoJSON = model.RegionGeoJSON;
            RefOrganizationTypeId = model.RefOrganizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
