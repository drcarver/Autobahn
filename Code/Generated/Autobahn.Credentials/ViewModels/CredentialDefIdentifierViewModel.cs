//**********************************************************
//* DomainName: Autobahn.Credentials
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
        /// The title of the CredentialDefIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialIdentifierSystemId"/> model
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
