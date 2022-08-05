//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationWebsiteViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationWebsiteViewModel
     /// </summary>
    public partial class OrganizationWebsiteViewModel : ViewModelBase, Interfaces.IOrganizationWebsite
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationWebsite";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Website property
        private System.String _Website;

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
        /// The title of the OrganizationWebsiteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String Website  { get => _Website; set => SetProperty(ref _Website, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationWebsite model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            Website = model.Website;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
