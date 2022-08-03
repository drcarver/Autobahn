//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardViewModel
     /// </summary>
    public partial class CredentialAwardViewModel : BindableBase, ICredentialAward
    {
#region "Backing Fields"
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

        // member variable for the EvidenceURL property
        private System.String _EvidenceURL;

        // member variable for the RevokedDate property
        private System.DateTime? _RevokedDate;

        // member variable for the RevokedIndicator property
        private System.Boolean? _RevokedIndicator;

        // member variable for the RevokedReason property
        private System.String _RevokedReason;

        // member variable for the CredentialAwardStartDate property
        private System.DateTime? _CredentialAwardStartDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuerId"/> model
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid? PersonId { get; set; }

        public System.String AdvancedStandingDescription  { get => _AdvancedStandingDescription; set => SetProperty(ref _AdvancedStandingDescription, value); }

        public System.String AdvancedStandingURL  { get => _AdvancedStandingURL; set => SetProperty(ref _AdvancedStandingURL, value); }

        public System.String ApproverName  { get => _ApproverName; set => SetProperty(ref _ApproverName, value); }

        public System.DateTime? CompletionDate { get => _CompletionDate; set => SetProperty(ref _CompletionDate, value); }

        public System.DateTime? CredentialAwardEndDate { get => _CredentialAwardEndDate; set => SetProperty(ref _CredentialAwardEndDate, value); }

        public System.String EvidenceURL  { get => _EvidenceURL; set => SetProperty(ref _EvidenceURL, value); }

        public System.DateTime? RevokedDate { get => _RevokedDate; set => SetProperty(ref _RevokedDate, value); }

        public System.Boolean? RevokedIndicator { get => _RevokedIndicator; set => SetProperty(ref _RevokedIndicator, value); }

        public System.String RevokedReason  { get => _RevokedReason; set => SetProperty(ref _RevokedReason, value); }

        public System.DateTime? CredentialAwardStartDate { get => _CredentialAwardStartDate; set => SetProperty(ref _CredentialAwardStartDate, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(ICredentialAward model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            CredentialIssuerId = model.CredentialIssuerId;
            PersonId = model.PersonId;
            AdvancedStandingDescription = model.AdvancedStandingDescription;
            AdvancedStandingURL = model.AdvancedStandingURL;
            ApproverName = model.ApproverName;
            CompletionDate = model.CompletionDate;
            CredentialAwardEndDate = model.CredentialAwardEndDate;
            EvidenceURL = model.EvidenceURL;
            RevokedDate = model.RevokedDate;
            RevokedIndicator = model.RevokedIndicator;
            RevokedReason = model.RevokedReason;
            CredentialAwardStartDate = model.CredentialAwardStartDate;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            OrganizationId = model.OrganizationId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
