//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentPerformanceLevelViewModel : ViewModelBase, Interfaces.IAssessmentPerformanceLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPerformanceLevel";

        // member variable for the ScoreMetric property
        private System.String _ScoreMetric;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPerformanceLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19407">Assessment Performance Level Score Metric</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Performance Level Score Metric")]
        public System.String ScoreMetric { get => _ScoreMetric; set => SetProperty(ref _ScoreMetric, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            ScoreMetric = model.ScoreMetric; // Assessment Performance Level Score Metric
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
