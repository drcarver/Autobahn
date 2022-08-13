//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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
        private System.DateTime? _AwardDate;

        // member variable for the DegreeOrCertificateTitleOrSubject property
        private System.String _DegreeOrCertificateTitleOrSubject;

        // member variable for the NameOfInstitution property
        private System.String _NameOfInstitution;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefDegreeOrCertificateTypeId property
        private Guid? _RefDegreeOrCertificateTypeId;

        // member variable for the RefEducationVerificationMethodId property
        private Guid? _RefEducationVerificationMethodId;

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDegreeOrCertificateViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.DateTime? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String DegreeOrCertificateTitleOrSubject { get => _DegreeOrCertificateTitleOrSubject; set => SetProperty(ref _DegreeOrCertificateTitleOrSubject, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String NameOfInstitution { get => _NameOfInstitution; set => SetProperty(ref _NameOfInstitution, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateType"/> model
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get => _RefDegreeOrCertificateTypeId; set => SetProperty(ref _RefDegreeOrCertificateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethod"/> model
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get => _RefEducationVerificationMethodId; set => SetProperty(ref _RefEducationVerificationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDegreeOrCertificate model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardDate = model.AwardDate;
            DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject;
            NameOfInstitution = model.NameOfInstitution;
            PersonId = model.PersonId;
            RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId;
            RefEducationVerificationMethodId = model.RefEducationVerificationMethodId;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
