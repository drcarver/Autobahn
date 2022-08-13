//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCohortViewModel
     /// </summary>
    public partial class K12StudentCohortViewModel : ViewModelBase, Interfaces.IK12StudentCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCohort";

        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // member variable for the CohortGraduationYear property
        private System.String _CohortGraduationYear;

        // member variable for the CohortYear property
        private System.String _CohortYear;

        // member variable for the GraduationRateSurveyCohortYear property
        private System.String _GraduationRateSurveyCohortYear;

        // member variable for the GraduationRateSurveyIndicator property
        private System.Boolean? _GraduationRateSurveyIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentCohortViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortDescription { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortGraduationYear { get => _CohortGraduationYear; set => SetProperty(ref _CohortGraduationYear, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortYear { get => _CohortYear; set => SetProperty(ref _CohortYear, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String GraduationRateSurveyCohortYear { get => _GraduationRateSurveyCohortYear; set => SetProperty(ref _GraduationRateSurveyCohortYear, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.Boolean? GraduationRateSurveyIndicator { get => _GraduationRateSurveyIndicator; set => SetProperty(ref _GraduationRateSurveyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
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
            CohortDescription = model.CohortDescription;
            CohortGraduationYear = model.CohortGraduationYear;
            CohortYear = model.CohortYear;
            GraduationRateSurveyCohortYear = model.GraduationRateSurveyCohortYear;
            GraduationRateSurveyIndicator = model.GraduationRateSurveyIndicator;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
