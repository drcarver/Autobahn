//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDegreeOrCertificateViewModel
     /// </summary>
    public partial class PersonDegreeOrCertificateViewModel : ViewModelBase, Interfaces.IPersonDegreeOrCertificate
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDegreeOrCertificate";

        // member variable for the AwardDate property
        private Guid? _AwardDate;

        // member variable for the DegreeOrCertificateTitleOrSubject property
        private  _DegreeOrCertificateTitleOrSubject;

        // member variable for the NameOfInstitution property
        private  _NameOfInstitution;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefDegreeOrCertificateTypeId property
        private  _RefDegreeOrCertificateTypeId;

        // member variable for the RefEducationVerificationMethodId property
        private  _RefEducationVerificationMethodId;

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private  _RefHigherEducationInstitutionAccreditationStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        /// <summary>
        /// </summary>
        public  DegreeOrCertificateTitleOrSubject { get => _DegreeOrCertificateTitleOrSubject; set => SetProperty(ref _DegreeOrCertificateTitleOrSubject, value); }

        /// <summary>
        /// </summary>
        public  NameOfInstitution { get => _NameOfInstitution; set => SetProperty(ref _NameOfInstitution, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateType"/> model
        /// </summary>
        public  RefDegreeOrCertificateTypeId { get => _RefDegreeOrCertificateTypeId; set => SetProperty(ref _RefDegreeOrCertificateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethod"/> model
        /// </summary>
        public  RefEducationVerificationMethodId { get => _RefEducationVerificationMethodId; set => SetProperty(ref _RefEducationVerificationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public  RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDegreeOrCertificate model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardDate = model.AwardDate; // 
            DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject; // 
            NameOfInstitution = model.NameOfInstitution; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId; // 
            RefEducationVerificationMethodId = model.RefEducationVerificationMethodId; // 
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
