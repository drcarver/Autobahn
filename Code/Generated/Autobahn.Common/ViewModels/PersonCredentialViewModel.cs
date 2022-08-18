//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialViewModel.cs
//* Name:       Name of Professional Credential or License
//* Definition: The name of the license/credential awarded by a given profession.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The name of the license/credential awarded by a given profession.
     /// </summary>
    public partial class PersonCredentialViewModel : ViewModelBase, Interfaces.IPersonCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCredential";

        // CredentialName -- (backing property for Name of Professional Credential or License)
        private System.String _CredentialName;

        // CredentialOrLicenseAwardEntity -- (backing property for Credential or License Award Entity)
        private System.String _CredentialOrLicenseAwardEntity;

        // ExpirationDate -- (backing property for Credential Expiration Date)
        private System.DateTime? _ExpirationDate;

        // IssuanceDate -- (backing property for Credential Issuance Date)
        private System.DateTime? _IssuanceDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // ProfessionalCertificateOrLicenseNumber -- (backing property for Professional Certificate or License Number)
        private System.String _ProfessionalCertificateOrLicenseNumber;

        // RefCredentialTypeId -- (backing property for Credential Type)
        private Guid? _RefCredentialTypeId;

        // RefIssuingStateId -- (backing property for State Issuing Professional Credential or License)
        private Guid? _RefIssuingStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Name of Professional Credential or License
        /// <para>
        /// The name of the license/credential awarded by a given profession.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CredentialName { get => _CredentialName; set => SetProperty(ref _CredentialName, value); }

        /// <summary>
        /// Credential or License Award Entity
        /// <para>
        /// The name of the organization awarding the individual's credential or license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20566">Credential or License Award Entity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CredentialOrLicenseAwardEntity { get => _CredentialOrLicenseAwardEntity; set => SetProperty(ref _CredentialOrLicenseAwardEntity, value); }

        /// <summary>
        /// Credential Expiration Date
        /// <para>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19069">Credential Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Credential Issuance Date
        /// <para>
        /// The year, month and day on which an active credential was issued to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19070">Credential Issuance Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? IssuanceDate { get => _IssuanceDate; set => SetProperty(ref _IssuanceDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Professional Certificate or License Number
        /// <para>
        /// The number issued by the credentialing/licensing agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20398">Professional Certificate or License Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ProfessionalCertificateOrLicenseNumber { get => _ProfessionalCertificateOrLicenseNumber; set => SetProperty(ref _ProfessionalCertificateOrLicenseNumber, value); }

        /// <summary>
        /// Credential Type
        /// <para>
        /// An indication of the category of credential a person holds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19071">Credential Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialTypeId { get => _RefCredentialTypeId; set => SetProperty(ref _RefCredentialTypeId, value); }

        /// <summary>
        /// State Issuing Professional Credential or License
        /// <para>
        /// State where the professional license/credential was issued.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19804">State Issuing Professional Credential or License</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIssuingStateId { get => _RefIssuingStateId; set => SetProperty(ref _RefIssuingStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialName = model.CredentialName; // Name of Professional Credential or License
            CredentialOrLicenseAwardEntity = model.CredentialOrLicenseAwardEntity; // Credential or License Award Entity
            ExpirationDate = model.ExpirationDate; // Credential Expiration Date
            IssuanceDate = model.IssuanceDate; // Credential Issuance Date
            PersonId = model.PersonId; // 
            ProfessionalCertificateOrLicenseNumber = model.ProfessionalCertificateOrLicenseNumber; // Professional Certificate or License Number
            RefCredentialTypeId = model.RefCredentialTypeId; // Credential Type
            RefIssuingStateId = model.RefIssuingStateId; // State Issuing Professional Credential or License
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefIssuingState List
        /// <summary>
        /// The complete Name of Professional Credential or License List
        /// </summary>
        private static List<ReferenceModelBase> RefIssuingStateList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
