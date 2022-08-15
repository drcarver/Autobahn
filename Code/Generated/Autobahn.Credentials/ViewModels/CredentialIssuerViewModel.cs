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
        private System.String _AwardIssuerOriginURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialIssuerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19900">Credential Award Issuer Origin URL</a>
        /// </para>
        /// </summary>
        [DisplayName("Credential Award Issuer Origin URL")]
        public System.String AwardIssuerOriginURL { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialIssuer model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardIssuerOriginURL = model.AwardIssuerOriginURL; // Credential Award Issuer Origin URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
