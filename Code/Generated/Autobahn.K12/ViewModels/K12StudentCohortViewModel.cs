//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortViewModel.cs
//* Name:       Cohort Description
//* Definition: A description of the student cohort.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// A description of the student cohort.
     /// </summary>
    public partial class K12StudentCohortViewModel : ViewModelBase, Interfaces.IK12StudentCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCohort";

        // CohortDescription -- (backing property for Cohort Description)
        private System.String _CohortDescription;

        // CohortGraduationYear -- (backing property for Cohort Graduation Year)
        private System.String _CohortGraduationYear;

        // CohortYear -- (backing property for Cohort Year)
        private System.String _CohortYear;

        // GraduationRateSurveyCohortYear -- (backing property for Graduation Rate Survey Cohort Year)
        private System.String _GraduationRateSurveyCohortYear;

        // GraduationRateSurveyIndicator -- (backing property for Graduation Rate Survey Indicator)
        private System.Boolean? _GraduationRateSurveyIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Cohort Description
        /// <para>
        /// A description of the student cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19687">Cohort Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CohortDescription { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

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
        /// Cohort Year
        /// <para>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19046">Cohort Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CohortYear { get => _CohortYear; set => SetProperty(ref _CohortYear, value); }

        /// <summary>
        /// Graduation Rate Survey Cohort Year
        /// <para>
        /// The academic year in which a student entered as part of the GRS cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19132">Graduation Rate Survey Cohort Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GraduationRateSurveyCohortYear { get => _GraduationRateSurveyCohortYear; set => SetProperty(ref _GraduationRateSurveyCohortYear, value); }

        /// <summary>
        /// Graduation Rate Survey Indicator
        /// <para>
        /// An indication of whether or not the student is in a GRS cohort; meaning the student began as a first-time, full-time, degree seeking student in the fall of a given year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19133">Graduation Rate Survey Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? GraduationRateSurveyIndicator { get => _GraduationRateSurveyIndicator; set => SetProperty(ref _GraduationRateSurveyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortDescription = model.CohortDescription; // Cohort Description
            CohortGraduationYear = model.CohortGraduationYear; // Cohort Graduation Year
            CohortYear = model.CohortYear; // Cohort Year
            GraduationRateSurveyCohortYear = model.GraduationRateSurveyCohortYear; // Graduation Rate Survey Cohort Year
            GraduationRateSurveyIndicator = model.GraduationRateSurveyIndicator; // Graduation Rate Survey Indicator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
