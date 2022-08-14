//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefIdentifierViewModel
     /// </summary>
    public partial class CredentialDefIdentifierViewModel : ViewModelBase, Interfaces.ICredentialDefIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefIdentifier";

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RefCredentialIdentifierSystemId property
        private Guid? _RefCredentialIdentifierSystemId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        public Guid? RefCredentialIdentifierSystemId { get => _RefCredentialIdentifierSystemId; set => SetProperty(ref _RefCredentialIdentifierSystemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            Identifier = model.Identifier;
            RefCredentialIdentifierSystemId = model.RefCredentialIdentifierSystemId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
