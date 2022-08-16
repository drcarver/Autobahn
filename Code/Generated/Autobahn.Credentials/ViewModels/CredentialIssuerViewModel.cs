//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialIssuerViewModel
     /// </summary>
    public partial class CredentialIssuerViewModel : ViewModelBase, Interfaces.ICredentialIssuer
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialIssuer";

        // member variable for the AwardIssuerOriginURL property
        private Guid? _AwardIssuerOriginURL;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCTDLOrganizationTypeId property
        private  _RefCTDLOrganizationTypeId;

        // member variable for the RevocationListURL property
        private  _RevocationListURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AwardIssuerOriginURL { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public  RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        /// <summary>
        /// </summary>
        public  RevocationListURL { get => _RevocationListURL; set => SetProperty(ref _RevocationListURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialIssuer model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardIssuerOriginURL = model.AwardIssuerOriginURL; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId; // 
            RevocationListURL = model.RevocationListURL; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
