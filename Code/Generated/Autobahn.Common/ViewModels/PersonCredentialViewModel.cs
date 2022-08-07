//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCredentialViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCredentialViewModel
     /// </summary>
    public partial class PersonCredentialViewModel : ViewModelBase, Interfaces.IPersonCredentialViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCredential";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the CredentialName property
        private System.String _CredentialName;

        // member variable for the RefCredentialTypeId property
        private Guid? _RefCredentialTypeId;

        // member variable for the IssuanceDate property
        private System.DateTime? _IssuanceDate;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the RefIssuingStateId property
        private Guid? _RefIssuingStateId;

        // member variable for the ProfessionalCertificateOrLicenseNumber property
        private System.String _ProfessionalCertificateOrLicenseNumber;

        // member variable for the CredentialOrLicenseAwardEntity property
        private System.String _CredentialOrLicenseAwardEntity;

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
        /// The title of the PersonCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String CredentialName  { get => _CredentialName; set => SetProperty(ref _CredentialName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialTypeId"/> model
        /// </summary>
        public Guid? RefCredentialTypeId { get => _RefCredentialTypeId; set => SetProperty(ref _RefCredentialTypeId, value); }

        public System.DateTime? IssuanceDate { get => _IssuanceDate; set => SetProperty(ref _IssuanceDate, value); }

        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingStateId"/> model
        /// </summary>
        public Guid? RefIssuingStateId { get => _RefIssuingStateId; set => SetProperty(ref _RefIssuingStateId, value); }

        public System.String ProfessionalCertificateOrLicenseNumber  { get => _ProfessionalCertificateOrLicenseNumber; set => SetProperty(ref _ProfessionalCertificateOrLicenseNumber, value); }

        public System.String CredentialOrLicenseAwardEntity  { get => _CredentialOrLicenseAwardEntity; set => SetProperty(ref _CredentialOrLicenseAwardEntity, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            CredentialName = model.CredentialName;
            RefCredentialTypeId = model.RefCredentialTypeId;
            IssuanceDate = model.IssuanceDate;
            ExpirationDate = model.ExpirationDate;
            RefIssuingStateId = model.RefIssuingStateId;
            ProfessionalCertificateOrLicenseNumber = model.ProfessionalCertificateOrLicenseNumber;
            CredentialOrLicenseAwardEntity = model.CredentialOrLicenseAwardEntity;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
