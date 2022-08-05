//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefAgentViewModel
     /// </summary>
    public partial class CredentialDefAgentViewModel : ViewModelBase, Interfaces.ICredentialDefAgent
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefAgent";

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the PersonId property
        private Guid? _PersonId;

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

        // member variable for the RefCredentialDefAgentRoleTypeId property
        private Guid? _RefCredentialDefAgentRoleTypeId;

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
        /// The title of the CredentialDefAgentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid? PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefAgentRoleTypeId { get => _RefCredentialDefAgentRoleTypeId; set => SetProperty(ref _RefCredentialDefAgentRoleTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            PersonId = model.PersonId;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId;
            RefCredentialDefAgentRoleTypeId = model.RefCredentialDefAgentRoleTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
