//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProviderViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceProviderViewModel
     /// </summary>
    public partial class ServiceProviderViewModel : ViewModelBase, Interfaces.IServiceProviderViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvider";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ServiceProvidedId property
        private Guid _ServiceProvidedId;

        // member variable for the ServiceStaffId property
        private Guid _ServiceStaffId;

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
        /// The title of the ServiceProviderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceProvidedId"/> model
        /// </summary>
        public Guid ServiceProvidedId { get => _ServiceProvidedId; set => SetProperty(ref _ServiceProvidedId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceStaffId"/> model
        /// </summary>
        public Guid ServiceStaffId { get => _ServiceStaffId; set => SetProperty(ref _ServiceStaffId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvider model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ServiceProvidedId = model.ServiceProvidedId;
            ServiceStaffId = model.ServiceStaffId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
