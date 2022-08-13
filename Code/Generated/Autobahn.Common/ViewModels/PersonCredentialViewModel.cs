//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCredentialViewModel
     /// </summary>
    public partial class PersonCredentialViewModel : ViewModelBase, Interfaces.IPersonCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCredential";

        // member variable for the CredentialName property
        private System.String _CredentialName;

        // member variable for the CredentialOrLicenseAwardEntity property
        private System.String _CredentialOrLicenseAwardEntity;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the IssuanceDate property
        private System.DateTime? _IssuanceDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the ProfessionalCertificateOrLicenseNumber property
        private System.String _ProfessionalCertificateOrLicenseNumber;

        // member variable for the RefCredentialTypeId property
        private Guid? _RefCredentialTypeId;

        // member variable for the RefIssuingStateId property
        private Guid? _RefIssuingStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String CredentialName { get => _CredentialName; set => SetProperty(ref _CredentialName, value); }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String CredentialOrLicenseAwardEntity { get => _CredentialOrLicenseAwardEntity; set => SetProperty(ref _CredentialOrLicenseAwardEntity, value); }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.DateTime? IssuanceDate { get => _IssuanceDate; set => SetProperty(ref _IssuanceDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String ProfessionalCertificateOrLicenseNumber { get => _ProfessionalCertificateOrLicenseNumber; set => SetProperty(ref _ProfessionalCertificateOrLicenseNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialType"/> model
        /// </summary>
        public Guid? RefCredentialTypeId { get => _RefCredentialTypeId; set => SetProperty(ref _RefCredentialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingState"/> model
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
            CredentialName = model.CredentialName;
            CredentialOrLicenseAwardEntity = model.CredentialOrLicenseAwardEntity;
            ExpirationDate = model.ExpirationDate;
            IssuanceDate = model.IssuanceDate;
            PersonId = model.PersonId;
            ProfessionalCertificateOrLicenseNumber = model.ProfessionalCertificateOrLicenseNumber;
            RefCredentialTypeId = model.RefCredentialTypeId;
            RefIssuingStateId = model.RefIssuingStateId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
