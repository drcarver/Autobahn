//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicesReceivedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServicesReceivedViewModel
     /// </summary>
    public partial class ServicesReceivedViewModel : ViewModelBase, Interfaces.IServicesReceivedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicesReceived";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the ServicePlanId property
        private Guid _ServicePlanId;

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
        /// The title of the ServicesReceivedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlanId"/> model
        /// </summary>
        public Guid ServicePlanId { get => _ServicePlanId; set => SetProperty(ref _ServicePlanId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicesReceived model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            FullTimeEquivalency = model.FullTimeEquivalency;
            ServicePlanId = model.ServicePlanId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
