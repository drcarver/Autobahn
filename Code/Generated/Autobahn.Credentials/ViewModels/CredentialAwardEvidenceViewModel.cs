//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardEvidenceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardEvidenceViewModel
     /// </summary>
    public partial class CredentialAwardEvidenceViewModel : ViewModelBase, Interfaces.ICredentialAwardEvidence
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAwardEvidence";

        // member variable for the CredentialAwardId property
        private Guid _CredentialAwardId;

        // member variable for the Statement property
        private System.String _Statement;

        // member variable for the AssessmentResultId property
        private Guid? _AssessmentResultId;

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
        /// The title of the CredentialAwardEvidenceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAwardId"/> model
        /// </summary>
        public Guid CredentialAwardId { get => _CredentialAwardId; set => SetProperty(ref _CredentialAwardId, value); }

        public System.String Statement  { get => _Statement; set => SetProperty(ref _Statement, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResultId"/> model
        /// </summary>
        public Guid? AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAwardEvidence model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialAwardId = model.CredentialAwardId;
            Statement = model.Statement;
            AssessmentResultId = model.AssessmentResultId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
