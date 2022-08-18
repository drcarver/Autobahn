//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//* Name:       Diploma or Credential Award Date
//* Definition: The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
     /// </summary>
    public partial class PersonDegreeOrCertificateViewModel : ViewModelBase, Interfaces.IPersonDegreeOrCertificate
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDegreeOrCertificate";

        // AwardDate -- (backing property for Diploma or Credential Award Date)
        private System.DateTime? _AwardDate;

        // DegreeOrCertificateTitleOrSubject -- (backing property for Degree or Certificate Title or Subject)
        private System.String _DegreeOrCertificateTitleOrSubject;

        // NameOfInstitution -- (backing property for Name of Institution)
        private System.String _NameOfInstitution;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefDegreeOrCertificateTypeId -- (backing property for Degree or Certificate Type)
        private Guid? _RefDegreeOrCertificateTypeId;

        // RefEducationVerificationMethodId -- (backing property for Education Verification Method)
        private Guid? _RefEducationVerificationMethodId;

        // RefHigherEducationInstitutionAccreditationStatusId -- (backing property for Higher Education Institution Accreditation Status)
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        /// <summary>
        /// Degree or Certificate Title or Subject
        /// <para>
        /// The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19341">Degree or Certificate Title or Subject</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DegreeOrCertificateTitleOrSubject { get => _DegreeOrCertificateTitleOrSubject; set => SetProperty(ref _DegreeOrCertificateTitleOrSubject, value); }

        /// <summary>
        /// Name of Institution
        /// <para>
        /// The full legally accepted name of the institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19191">Name of Institution</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String NameOfInstitution { get => _NameOfInstitution; set => SetProperty(ref _NameOfInstitution, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Degree or Certificate Type
        /// <para>
        /// The type of degree or certificate earned by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get => _RefDegreeOrCertificateTypeId; set => SetProperty(ref _RefDegreeOrCertificateTypeId, value); }

        /// <summary>
        /// Education Verification Method
        /// <para>
        /// The method by which the formal education is verified.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get => _RefEducationVerificationMethodId; set => SetProperty(ref _RefEducationVerificationMethodId, value); }

        /// <summary>
        /// Higher Education Institution Accreditation Status
        /// <para>
        /// An indication of the accreditation status of a higher education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
        /// </para>
        /// </summary>
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
            AwardDate = model.AwardDate; // Diploma or Credential Award Date
            DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject; // Degree or Certificate Title or Subject
            NameOfInstitution = model.NameOfInstitution; // Name of Institution
            PersonId = model.PersonId; // 
            RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId; // Degree or Certificate Type
            RefEducationVerificationMethodId = model.RefEducationVerificationMethodId; // Education Verification Method
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // Higher Education Institution Accreditation Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
