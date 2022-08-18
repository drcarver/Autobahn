//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerViewModel.cs
//* Name:       Credential Award Issuer Origin URL
//* Definition: The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
     /// </summary>
    public partial class CredentialIssuerViewModel : ViewModelBase, Interfaces.ICredentialIssuer
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialIssuer";

        // AwardIssuerOriginURL -- (backing property for Credential Award Issuer Origin URL)
        private System.String _AwardIssuerOriginURL;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefCTDLOrganizationTypeId -- (backing property for CTDL Organization Type)
        private Guid? _RefCTDLOrganizationTypeId;

        // RevocationListURL -- (backing property for Credential Issuer Revocation List URL)
        private System.String _RevocationListURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credential Award Issuer Origin URL
        /// <para>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19900">Credential Award Issuer Origin URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AwardIssuerOriginURL { get => _AwardIssuerOriginURL; set => SetProperty(ref _AwardIssuerOriginURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// CTDL Organization Type
        /// <para>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20736">CTDL Organization Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        /// <summary>
        /// Credential Issuer Revocation List URL
        /// <para>
        /// The URL to a document that includes a list of credential award assertions an issuer has revoked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20643">Credential Issuer Revocation List URL</a>
        /// </para>
        /// </summary>
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
            AwardIssuerOriginURL = model.AwardIssuerOriginURL; // Credential Award Issuer Origin URL
            OrganizationId = model.OrganizationId; // 
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId; // CTDL Organization Type
            RevocationListURL = model.RevocationListURL; // Credential Issuer Revocation List URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
