//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleRelationshipViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleRelationshipViewModel
     /// </summary>
    public partial class OrganizationPersonRoleRelationshipViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleRelationshipViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleRelationship";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the OrganizationPersonRoleId_Parent property
        private System.Int32 _OrganizationPersonRoleId_Parent;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Int32 OrganizationPersonRoleId_Parent  { get => _OrganizationPersonRoleId_Parent; set => SetProperty(ref _OrganizationPersonRoleId_Parent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            OrganizationPersonRoleId_Parent = model.OrganizationPersonRoleId_Parent;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
