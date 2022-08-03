//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardEvidenceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardEvidenceViewModel
     /// </summary>
    public partial class CredentialAwardEvidenceViewModel : BindableBase, ICredentialAwardEvidence
    {
#region "Backing Fields"
        // member variable for the Statement property
        private System.String _Statement;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAwardId"/> model
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        public System.String Statement  { get => _Statement; set => SetProperty(ref _Statement, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResultId"/> model
        /// </summary>
        public Guid? AssessmentResultId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(ICredentialAwardEvidence model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialAwardId = model.CredentialAwardId;
            Statement = model.Statement;
            AssessmentResultId = model.AssessmentResultId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
