//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _CredentialName;

        // member variable for the CredentialOrLicenseAwardEntity property
        private  _CredentialOrLicenseAwardEntity;

        // member variable for the ExpirationDate property
        private Guid? _ExpirationDate;

        // member variable for the IssuanceDate property
        private  _IssuanceDate;

        // member variable for the ProfessionalCertificateOrLicenseNumber property
        private  _ProfessionalCertificateOrLicenseNumber;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCredentialTypeId property
        private  _RefCredentialTypeId;

        // member variable for the RefIssuingStateId property
        private  _RefIssuingStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CredentialName { get => _CredentialName; set => SetProperty(ref _CredentialName, value); }

        /// <summary>
        /// </summary>
        public  CredentialOrLicenseAwardEntity { get => _CredentialOrLicenseAwardEntity; set => SetProperty(ref _CredentialOrLicenseAwardEntity, value); }

        /// <summary>
        /// </summary>
        public Guid? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// </summary>
        public  IssuanceDate { get => _IssuanceDate; set => SetProperty(ref _IssuanceDate, value); }

        /// <summary>
        /// </summary>
        public  ProfessionalCertificateOrLicenseNumber { get => _ProfessionalCertificateOrLicenseNumber; set => SetProperty(ref _ProfessionalCertificateOrLicenseNumber, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialType"/> model
        /// </summary>
        public  RefCredentialTypeId { get => _RefCredentialTypeId; set => SetProperty(ref _RefCredentialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingState"/> model
        /// </summary>
        public  RefIssuingStateId { get => _RefIssuingStateId; set => SetProperty(ref _RefIssuingStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialName = model.CredentialName; // 
            CredentialOrLicenseAwardEntity = model.CredentialOrLicenseAwardEntity; // 
            ExpirationDate = model.ExpirationDate; // 
            IssuanceDate = model.IssuanceDate; // 
            ProfessionalCertificateOrLicenseNumber = model.ProfessionalCertificateOrLicenseNumber; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCredentialTypeId = model.RefCredentialTypeId; // 
            RefIssuingStateId = model.RefIssuingStateId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
