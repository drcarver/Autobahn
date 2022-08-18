//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefIdentifier View Model
     /// </summary>
    public partial class CredentialDefIdentifierViewModel : ViewModelBase, Interfaces.ICredentialDefIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefIdentifier";

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // Identifier -- (backing property for Credential Definition Identifier)
        private System.String _Identifier;

        // RefCredentialIdentifierSystemId -- (backing property for Credential Definition Identifier System)
        private Guid? _RefCredentialIdentifierSystemId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Credential Definition Identifier
        /// <para>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Credential Definition Identifier System
        /// <para>
        /// A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20720">Credential Definition Identifier System</a>
        /// </para>
        /// </summary>
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
            CredentialDefinitionId = model.CredentialDefinitionId; // 
            Identifier = model.Identifier; // Credential Definition Identifier
            RefCredentialIdentifierSystemId = model.RefCredentialIdentifierSystemId; // Credential Definition Identifier System
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
