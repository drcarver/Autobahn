//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardViewModel
     /// </summary>
    public partial class CredentialAwardViewModel : ViewModelBase, Interfaces.ICredentialAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAward";

        // member variable for the AdvancedStandingDescription property
        private System.String _AdvancedStandingDescription;

        // member variable for the AdvancedStandingURL property
        private System.String _AdvancedStandingURL;

        // member variable for the ApproverName property
        private System.String _ApproverName;

        // member variable for the CompletionDate property
        private System.DateTime? _CompletionDate;

        // member variable for the CredentialAwardEndDate property
        private System.DateTime? _CredentialAwardEndDate;

        // member variable for the CredentialAwardStartDate property
        private System.DateTime? _CredentialAwardStartDate;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CredentialIssuerId property
        private Guid _CredentialIssuerId;

        // member variable for the EvidenceURL property
        private System.String _EvidenceURL;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the PersonId property
        private Guid? _PersonId;

        // member variable for the RevokedDate property
        private System.DateTime? _RevokedDate;

        // member variable for the RevokedIndicator property
        private System.Boolean? _RevokedIndicator;

        // member variable for the RevokedReason property
        private System.String _RevokedReason;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String AdvancedStandingDescription { get => _AdvancedStandingDescription; set => SetProperty(ref _AdvancedStandingDescription, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String AdvancedStandingURL { get => _AdvancedStandingURL; set => SetProperty(ref _AdvancedStandingURL, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String ApproverName { get => _ApproverName; set => SetProperty(ref _ApproverName, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CompletionDate { get => _CompletionDate; set => SetProperty(ref _CompletionDate, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CredentialAwardEndDate { get => _CredentialAwardEndDate; set => SetProperty(ref _CredentialAwardEndDate, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get => _CredentialAwardStartDate; set => SetProperty(ref _CredentialAwardStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get => _CredentialIssuerId; set => SetProperty(ref _CredentialIssuerId, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String EvidenceURL { get => _EvidenceURL; set => SetProperty(ref _EvidenceURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid? PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? RevokedDate { get => _RevokedDate; set => SetProperty(ref _RevokedDate, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.Boolean? RevokedIndicator { get => _RevokedIndicator; set => SetProperty(ref _RevokedIndicator, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String RevokedReason { get => _RevokedReason; set => SetProperty(ref _RevokedReason, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AdvancedStandingDescription = model.AdvancedStandingDescription;
            AdvancedStandingURL = model.AdvancedStandingURL;
            ApproverName = model.ApproverName;
            CompletionDate = model.CompletionDate;
            CredentialAwardEndDate = model.CredentialAwardEndDate;
            CredentialAwardStartDate = model.CredentialAwardStartDate;
            CredentialDefinitionId = model.CredentialDefinitionId;
            CredentialIssuerId = model.CredentialIssuerId;
            EvidenceURL = model.EvidenceURL;
            OrganizationId = model.OrganizationId;
            PersonId = model.PersonId;
            RevokedDate = model.RevokedDate;
            RevokedIndicator = model.RevokedIndicator;
            RevokedReason = model.RevokedReason;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
