//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStudentAcademicRecord View Model
     /// </summary>
    public partial class AeStudentAcademicRecordViewModel : ViewModelBase, Interfaces.IAeStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStudentAcademicRecord";

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefHighSchoolDiplomaTypeId -- (backing property for High School Diploma Type)
        private Guid? _RefHighSchoolDiplomaTypeId;

        // RefProfessionalTechnicalCredentialTypeId -- (backing property for Professional or Technical Credential Conferred)
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

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
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// High School Diploma Type
        /// <para>
        /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get => _RefHighSchoolDiplomaTypeId; set => SetProperty(ref _RefHighSchoolDiplomaTypeId, value); }

        /// <summary>
        /// Professional or Technical Credential Conferred
        /// <para>
        /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // High School Diploma Type
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
