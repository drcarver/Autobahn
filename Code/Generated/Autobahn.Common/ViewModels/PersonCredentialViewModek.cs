//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCredentialViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCredentialViewModel
     /// </summary>
    public partial class PersonCredentialViewModel : BindableBase, IPersonCredential
    {
#region "Backing Fields"
        // member variable for the CredentialName property
        private System.String _CredentialName;

        // member variable for the IssuanceDate property
        private System.DateTime? _IssuanceDate;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the ProfessionalCertificateOrLicenseNumber property
        private System.String _ProfessionalCertificateOrLicenseNumber;

        // member variable for the CredentialOrLicenseAwardEntity property
        private System.String _CredentialOrLicenseAwardEntity;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.String CredentialName  { get => _CredentialName; set => SetProperty(ref _CredentialName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialTypeId"/> model
        /// </summary>
        public Guid? RefCredentialTypeId { get; set; }

        public System.DateTime? IssuanceDate { get => _IssuanceDate; set => SetProperty(ref _IssuanceDate, value); }

        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingStateId"/> model
        /// </summary>
        public Guid? RefIssuingStateId { get; set; }

        public System.String ProfessionalCertificateOrLicenseNumber  { get => _ProfessionalCertificateOrLicenseNumber; set => SetProperty(ref _ProfessionalCertificateOrLicenseNumber, value); }

        public System.String CredentialOrLicenseAwardEntity  { get => _CredentialOrLicenseAwardEntity; set => SetProperty(ref _CredentialOrLicenseAwardEntity, value); }

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
        public void Load(IPersonCredential model)
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
