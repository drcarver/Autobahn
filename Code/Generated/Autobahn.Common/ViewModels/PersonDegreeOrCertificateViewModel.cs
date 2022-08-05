//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//**********************************************************


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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the DegreeOrCertificateTitleOrSubject property
        private System.String _DegreeOrCertificateTitleOrSubject;

        // member variable for the RefDegreeOrCertificateTypeId property
        private Guid? _RefDegreeOrCertificateTypeId;

        // member variable for the AwardDate property
        private System.DateTime? _AwardDate;

        // member variable for the NameOfInstitution property
        private System.String _NameOfInstitution;

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        // member variable for the RefEducationVerificationMethodId property
        private Guid? _RefEducationVerificationMethodId;

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
        /// The title of the PersonDegreeOrCertificateViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String DegreeOrCertificateTitleOrSubject  { get => _DegreeOrCertificateTitleOrSubject; set => SetProperty(ref _DegreeOrCertificateTitleOrSubject, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateTypeId"/> model
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get => _RefDegreeOrCertificateTypeId; set => SetProperty(ref _RefDegreeOrCertificateTypeId, value); }

        public System.DateTime? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        public System.String NameOfInstitution  { get => _NameOfInstitution; set => SetProperty(ref _NameOfInstitution, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatusId"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethodId"/> model
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get => _RefEducationVerificationMethodId; set => SetProperty(ref _RefEducationVerificationMethodId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDegreeOrCertificate model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject;
            RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId;
            AwardDate = model.AwardDate;
            NameOfInstitution = model.NameOfInstitution;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId;
            RefEducationVerificationMethodId = model.RefEducationVerificationMethodId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
