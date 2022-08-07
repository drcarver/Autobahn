//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPolicyViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPolicyViewModel
     /// </summary>
    public partial class OrganizationPolicyViewModel : ViewModelBase, Interfaces.IOrganizationPolicyViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPolicy";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PolicyType property
        private System.String _PolicyType;

        // member variable for the Value property
        private System.String _Value;

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
        /// The title of the OrganizationPolicyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String PolicyType  { get => _PolicyType; set => SetProperty(ref _PolicyType, value); }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPolicy model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            PolicyType = model.PolicyType;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
