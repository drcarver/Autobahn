//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefAgentCredentialViewModel
     /// </summary>
    public partial class CredentialDefAgentCredentialViewModel : ViewModelBase, Interfaces.ICredentialDefAgentCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefAgentCredential";

        // member variable for the CredentialDefAgentId property
        private Guid _CredentialDefAgentId;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefAgentCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefAgent"/> model
        /// </summary>
        public Guid CredentialDefAgentId { get => _CredentialDefAgentId; set => SetProperty(ref _CredentialDefAgentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgentCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefAgentId = model.CredentialDefAgentId;
            CredentialDefinitionId = model.CredentialDefinitionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
