//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialOfferedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialOfferedViewModel
     /// </summary>
    public partial class CredentialOfferedViewModel : BindableBase, ICredentialOffered
    {
#region "Backing Fields"
        // member variable for the CredentialOfferedStartDate property
        private System.DateTime? _CredentialOfferedStartDate;

        // member variable for the CredentialOfferedEndDate property
        private System.DateTime? _CredentialOfferedEndDate;

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

        public System.DateTime? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        public System.DateTime? CredentialOfferedEndDate { get => _CredentialOfferedEndDate; set => SetProperty(ref _CredentialOfferedEndDate, value); }

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
        public void Load(ICredentialOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            CredentialIssuerId = model.CredentialIssuerId;
            CredentialOfferedStartDate = model.CredentialOfferedStartDate;
            CredentialOfferedEndDate = model.CredentialOfferedEndDate;
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
