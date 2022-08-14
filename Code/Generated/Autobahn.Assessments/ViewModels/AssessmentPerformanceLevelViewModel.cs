//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the AssessmentSubtestId property
        private Guid? _AssessmentSubtestId;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Label property
        private System.String _Label;

        // member variable for the LowerCutScore property
        private System.String _LowerCutScore;

        // member variable for the ScoreMetric property
        private System.String _ScoreMetric;

        // member variable for the UpperCutScore property
        private System.String _UpperCutScore;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPerformanceLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid? AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String Label { get => _Label; set => SetProperty(ref _Label, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String LowerCutScore { get => _LowerCutScore; set => SetProperty(ref _LowerCutScore, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String ScoreMetric { get => _ScoreMetric; set => SetProperty(ref _ScoreMetric, value); }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String UpperCutScore { get => _UpperCutScore; set => SetProperty(ref _UpperCutScore, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubtestId = model.AssessmentSubtestId;
            DescriptiveFeedback = model.DescriptiveFeedback;
            Identifier = model.Identifier;
            Label = model.Label;
            LowerCutScore = model.LowerCutScore;
            ScoreMetric = model.ScoreMetric;
            UpperCutScore = model.UpperCutScore;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
