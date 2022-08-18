//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortViewModel.cs
//* Name:       Cohort Graduation Year
//* Definition: The year the cohort is expected to graduate.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The year the cohort is expected to graduate.
     /// </summary>
    public partial class PsStudentCohortViewModel : ViewModelBase, Interfaces.IPsStudentCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentCohort";

        // CohortGraduationYear -- (backing property for Cohort Graduation Year)
        private System.String _CohortGraduationYear;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Cohort Graduation Year
        /// <para>
        /// The year the cohort is expected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CohortGraduationYear { get => _CohortGraduationYear; set => SetProperty(ref _CohortGraduationYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortGraduationYear = model.CohortGraduationYear; // Cohort Graduation Year
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
