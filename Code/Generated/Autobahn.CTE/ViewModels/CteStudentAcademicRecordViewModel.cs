//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordViewModel.cs
//* Name:       Credits Attempted Cumulative
//* Definition: The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
     /// </summary>
    public partial class CteStudentAcademicRecordViewModel : ViewModelBase, Interfaces.ICteStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CteStudentAcademicRecord";

        // CreditsAttemptedCumulative -- (backing property for Credits Attempted Cumulative)
        private System.Decimal? _CreditsAttemptedCumulative;

        // CreditsEarnedCumulative -- (backing property for Credits Earned Cumulative)
        private System.Decimal? _CreditsEarnedCumulative;

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefProfessionalTechnicalCredentialTypeId -- (backing property for Professional or Technical Credential Conferred)
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credits Attempted Cumulative
        /// <para>
        /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// Credits Earned Cumulative
        /// <para>
        /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

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
        public void Load(Interfaces.ICteStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // Credits Attempted Cumulative
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // Credits Earned Cumulative
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
