//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialOfferedViewModel
     /// </summary>
    public partial class CredentialOfferedViewModel : ViewModelBase, Interfaces.ICredentialOfferedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialOffered";

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CredentialIssuerId property
        private Guid _CredentialIssuerId;

        // member variable for the CredentialOfferedStartDate property
        private System.DateTime? _CredentialOfferedStartDate;

        // member variable for the CredentialOfferedEndDate property
        private System.DateTime? _CredentialOfferedEndDate;

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
        /// The title of the CredentialOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuerId"/> model
        /// </summary>
        public Guid CredentialIssuerId { get => _CredentialIssuerId; set => SetProperty(ref _CredentialIssuerId, value); }

        public System.DateTime? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        public System.DateTime? CredentialOfferedEndDate { get => _CredentialOfferedEndDate; set => SetProperty(ref _CredentialOfferedEndDate, value); }

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
            CredentialOfferedStartDate = model.CredentialOfferedStartDate;
            CredentialOfferedEndDate = model.CredentialOfferedEndDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
