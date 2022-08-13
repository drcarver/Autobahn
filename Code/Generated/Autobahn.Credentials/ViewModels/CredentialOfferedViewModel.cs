//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialOfferedViewModel
     /// </summary>
    public partial class CredentialOfferedViewModel : ViewModelBase, Interfaces.ICredentialOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialOffered";

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CredentialIssuerId property
        private Guid _CredentialIssuerId;

        // member variable for the CredentialOfferedEndDate property
        private System.DateTime? _CredentialOfferedEndDate;

        // member variable for the CredentialOfferedStartDate property
        private System.DateTime? _CredentialOfferedStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get => _CredentialIssuerId; set => SetProperty(ref _CredentialIssuerId, value); }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public System.DateTime? CredentialOfferedEndDate { get => _CredentialOfferedEndDate; set => SetProperty(ref _CredentialOfferedEndDate, value); }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public System.DateTime? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            CredentialIssuerId = model.CredentialIssuerId;
            CredentialOfferedEndDate = model.CredentialOfferedEndDate;
            CredentialOfferedStartDate = model.CredentialOfferedStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
