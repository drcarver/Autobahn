//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AdvancedStandingDescription;

        // member variable for the AdvancedStandingURL property
        private  _AdvancedStandingURL;

        // member variable for the ApproverName property
        private  _ApproverName;

        // member variable for the CompletionDate property
        private  _CompletionDate;

        // member variable for the CredentialAwardEndDate property
        private  _CredentialAwardEndDate;

        // member variable for the CredentialAwardStartDate property
        private Guid? _CredentialAwardStartDate;

        // member variable for the EvidenceURL property
        private  _EvidenceURL;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RevokedDate property
        private  _RevokedDate;

        // member variable for the RevokedIndicator property
        private  _RevokedIndicator;

        // member variable for the RevokedReason property
        private  _RevokedReason;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AdvancedStandingDescription { get => _AdvancedStandingDescription; set => SetProperty(ref _AdvancedStandingDescription, value); }

        /// <summary>
        /// </summary>
        public  AdvancedStandingURL { get => _AdvancedStandingURL; set => SetProperty(ref _AdvancedStandingURL, value); }

        /// <summary>
        /// </summary>
        public  ApproverName { get => _ApproverName; set => SetProperty(ref _ApproverName, value); }

        /// <summary>
        /// </summary>
        public  CompletionDate { get => _CompletionDate; set => SetProperty(ref _CompletionDate, value); }

        /// <summary>
        /// </summary>
        public  CredentialAwardEndDate { get => _CredentialAwardEndDate; set => SetProperty(ref _CredentialAwardEndDate, value); }

        /// <summary>
        /// </summary>
        public Guid? CredentialAwardStartDate { get => _CredentialAwardStartDate; set => SetProperty(ref _CredentialAwardStartDate, value); }

        /// <summary>
        /// </summary>
        public  EvidenceURL { get => _EvidenceURL; set => SetProperty(ref _EvidenceURL, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  RevokedDate { get => _RevokedDate; set => SetProperty(ref _RevokedDate, value); }

        /// <summary>
        /// </summary>
        public  RevokedIndicator { get => _RevokedIndicator; set => SetProperty(ref _RevokedIndicator, value); }

        /// <summary>
        /// </summary>
        public  RevokedReason { get => _RevokedReason; set => SetProperty(ref _RevokedReason, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AdvancedStandingDescription = model.AdvancedStandingDescription; // 
            AdvancedStandingURL = model.AdvancedStandingURL; // 
            ApproverName = model.ApproverName; // 
            CompletionDate = model.CompletionDate; // 
            CredentialAwardEndDate = model.CredentialAwardEndDate; // 
            CredentialAwardStartDate = model.CredentialAwardStartDate; // 
            EvidenceURL = model.EvidenceURL; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RevokedDate = model.RevokedDate; // 
            RevokedIndicator = model.RevokedIndicator; // 
            RevokedReason = model.RevokedReason; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
