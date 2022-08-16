//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _CohortDescription;

        // member variable for the CohortGraduationYear property
        private  _CohortGraduationYear;

        // member variable for the CohortYear property
        private Guid? _CohortYear;

        // member variable for the GraduationRateSurveyCohortYear property
        private  _GraduationRateSurveyCohortYear;

        // member variable for the GraduationRateSurveyIndicator property
        private  _GraduationRateSurveyIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CohortDescription { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        /// <summary>
        /// </summary>
        public  CohortGraduationYear { get => _CohortGraduationYear; set => SetProperty(ref _CohortGraduationYear, value); }

        /// <summary>
        /// </summary>
        public Guid? CohortYear { get => _CohortYear; set => SetProperty(ref _CohortYear, value); }

        /// <summary>
        /// </summary>
        public  GraduationRateSurveyCohortYear { get => _GraduationRateSurveyCohortYear; set => SetProperty(ref _GraduationRateSurveyCohortYear, value); }

        /// <summary>
        /// </summary>
        public  GraduationRateSurveyIndicator { get => _GraduationRateSurveyIndicator; set => SetProperty(ref _GraduationRateSurveyIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortDescription = model.CohortDescription; // 
            CohortGraduationYear = model.CohortGraduationYear; // 
            CohortYear = model.CohortYear; // 
            GraduationRateSurveyCohortYear = model.GraduationRateSurveyCohortYear; // 
            GraduationRateSurveyIndicator = model.GraduationRateSurveyIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
