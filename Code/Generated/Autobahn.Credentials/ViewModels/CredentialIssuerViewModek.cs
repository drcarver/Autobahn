//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialIssuerViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialIssuerViewModel
     /// </summary>
    public partial class CredentialIssuerViewModel : BindableBase, ICredentialIssuer
    {
#region "Backing Fields"
        // member variable for the AwardIssuerOriginURL property
        private System.String _AwardIssuerOriginURL;

        // member variable for the RevocationListURL property
        private System.String _RevocationListURL;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.String AwardIssuerOriginURL  { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        public System.String RevocationListURL  { get => _RevocationListURL; set => SetProperty(ref _RevocationListURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

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
        public void Load(ICredentialIssuer model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AwardIssuerOriginURL = model.AwardIssuerOriginURL;
            RevocationListURL = model.RevocationListURL;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId;
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
