//**********************************************************
//* DomainName: Credentials
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

        // member variable for the RefCredentialDefAgentRoleTypeId property
        private Guid? _RefCredentialDefAgentRoleTypeId;

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefAgentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid? PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        public Guid? RefCredentialDefAgentRoleTypeId { get => _RefCredentialDefAgentRoleTypeId; set => SetProperty(ref _RefCredentialDefAgentRoleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

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
            RefCredentialDefAgentRoleTypeId = model.RefCredentialDefAgentRoleTypeId;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
