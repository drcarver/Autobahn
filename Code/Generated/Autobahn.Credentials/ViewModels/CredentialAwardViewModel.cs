//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardViewModel.cs
//* Name:       Credential Advanced Standing Description
//* Definition: A description of a credential that reduced the time or cost of attaining this credential.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// A description of a credential that reduced the time or cost of attaining this credential.
     /// </summary>
    public partial class CredentialAwardViewModel : ViewModelBase, Interfaces.ICredentialAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAward";

        // AdvancedStandingDescription -- (backing property for Credential Advanced Standing Description)
        private System.String _AdvancedStandingDescription;

        // AdvancedStandingURL -- (backing property for Credential Advanced Standing URL)
        private System.String _AdvancedStandingURL;

        // ApproverName -- (backing property for Credential Award Approver Name)
        private System.String _ApproverName;

        // CompletionDate -- (backing property for Credential Completion Date)
        private System.DateTime? _CompletionDate;

        // CredentialAwardEndDate -- (backing property for Credential Award End Date)
        private System.DateTime? _CredentialAwardEndDate;

        // CredentialAwardStartDate -- (backing property for Credential Award Start Date)
        private System.DateTime? _CredentialAwardStartDate;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CredentialIssuerId property
        private Guid _CredentialIssuerId;

        // EvidenceURL -- (backing property for Credential Award Evidence URL)
        private System.String _EvidenceURL;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the PersonId property
        private Guid? _PersonId;

        // RevokedDate -- (backing property for Credential Revoked Date)
        private System.DateTime? _RevokedDate;

        // RevokedIndicator -- (backing property for Credential Revoked Indicator)
        private System.Boolean? _RevokedIndicator;

        // RevokedReason -- (backing property for Credential Revoked Reason)
        private System.String _RevokedReason;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credential Advanced Standing Description
        /// <para>
        /// A description of a credential that reduced the time or cost of attaining this credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AdvancedStandingDescription { get => _AdvancedStandingDescription; set => SetProperty(ref _AdvancedStandingDescription, value); }

        /// <summary>
        /// Credential Advanced Standing URL
        /// <para>
        /// A URL that resolves to information about a credential that reduced the time or cost of attaining this credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20716">Credential Advanced Standing URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AdvancedStandingURL { get => _AdvancedStandingURL; set => SetProperty(ref _AdvancedStandingURL, value); }

        /// <summary>
        /// Credential Award Approver Name
        /// <para>
        /// Pronouncement of a favorable judgment by the agent being referenced.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20718">Credential Award Approver Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ApproverName { get => _ApproverName; set => SetProperty(ref _ApproverName, value); }

        /// <summary>
        /// Credential Completion Date
        /// <para>
        /// The date on which the person's requirements for earning a credential were met or completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20645">Credential Completion Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CompletionDate { get => _CompletionDate; set => SetProperty(ref _CompletionDate, value); }

        /// <summary>
        /// Credential Award End Date
        /// <para>
        /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20121">Credential Award End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CredentialAwardEndDate { get => _CredentialAwardEndDate; set => SetProperty(ref _CredentialAwardEndDate, value); }

        /// <summary>
        /// Credential Award Start Date
        /// <para>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get => _CredentialAwardStartDate; set => SetProperty(ref _CredentialAwardStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get => _CredentialIssuerId; set => SetProperty(ref _CredentialIssuerId, value); }

        /// <summary>
        /// Credential Award Evidence URL
        /// <para>
        /// A URL to a page that describes the evidence that the learner met the criteria for attainment of the credential award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20650">Credential Award Evidence URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EvidenceURL { get => _EvidenceURL; set => SetProperty(ref _EvidenceURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid? PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Credential Revoked Date
        /// <para>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20641">Credential Revoked Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? RevokedDate { get => _RevokedDate; set => SetProperty(ref _RevokedDate, value); }

        /// <summary>
        /// Credential Revoked Indicator
        /// <para>
        /// Indicates whether the credential has been revoked by the credential provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20732">Credential Revoked Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? RevokedIndicator { get => _RevokedIndicator; set => SetProperty(ref _RevokedIndicator, value); }

        /// <summary>
        /// Credential Revoked Reason
        /// <para>
        /// Published reason for revocation of a credential award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20642">Credential Revoked Reason</a>
        /// </para>
        /// </summary>
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
            AdvancedStandingDescription = model.AdvancedStandingDescription; // Credential Advanced Standing Description
            AdvancedStandingURL = model.AdvancedStandingURL; // Credential Advanced Standing URL
            ApproverName = model.ApproverName; // Credential Award Approver Name
            CompletionDate = model.CompletionDate; // Credential Completion Date
            CredentialAwardEndDate = model.CredentialAwardEndDate; // Credential Award End Date
            CredentialAwardStartDate = model.CredentialAwardStartDate; // Credential Award Start Date
            CredentialDefinitionId = model.CredentialDefinitionId; // 
            CredentialIssuerId = model.CredentialIssuerId; // 
            EvidenceURL = model.EvidenceURL; // Credential Award Evidence URL
            OrganizationId = model.OrganizationId; // 
            PersonId = model.PersonId; // 
            RevokedDate = model.RevokedDate; // Credential Revoked Date
            RevokedIndicator = model.RevokedIndicator; // Credential Revoked Indicator
            RevokedReason = model.RevokedReason; // Credential Revoked Reason
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
