//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _AwardIssuerOriginURL;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

        // member variable for the RevocationListURL property
        private System.String _RevocationListURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialIssuerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        public System.String AwardIssuerOriginURL { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        public System.String RevocationListURL { get => _RevocationListURL; set => SetProperty(ref _RevocationListURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialIssuer model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardIssuerOriginURL = model.AwardIssuerOriginURL;
            OrganizationId = model.OrganizationId;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId;
            RevocationListURL = model.RevocationListURL;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
