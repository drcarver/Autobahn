//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialIssuerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialIssuerViewModel
     /// </summary>
    public partial class CredentialIssuerViewModel : ViewModelBase, Interfaces.ICredentialIssuerViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialIssuer";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the AwardIssuerOriginURL property
        private System.String _AwardIssuerOriginURL;

        // member variable for the RevocationListURL property
        private System.String _RevocationListURL;

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

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
        /// The title of the CredentialIssuerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String AwardIssuerOriginURL  { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        public System.String RevocationListURL  { get => _RevocationListURL; set => SetProperty(ref _RevocationListURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialIssuer model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AwardIssuerOriginURL = model.AwardIssuerOriginURL;
            RevocationListURL = model.RevocationListURL;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
