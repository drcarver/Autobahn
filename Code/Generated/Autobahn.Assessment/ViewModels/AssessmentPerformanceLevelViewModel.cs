//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentPerformanceLevelViewModel : ViewModelBase, Interfaces.IAssessmentPerformanceLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPerformanceLevel";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the AssessmentSubtestId property
        private Guid? _AssessmentSubtestId;

        // member variable for the ScoreMetric property
        private System.String _ScoreMetric;

        // member variable for the Label property
        private System.String _Label;

        // member variable for the LowerCutScore property
        private System.String _LowerCutScore;

        // member variable for the UpperCutScore property
        private System.String _UpperCutScore;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPerformanceLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid? AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        public System.String ScoreMetric  { get => _ScoreMetric; set => SetProperty(ref _ScoreMetric, value); }

        public System.String Label  { get => _Label; set => SetProperty(ref _Label, value); }

        public System.String LowerCutScore  { get => _LowerCutScore; set => SetProperty(ref _LowerCutScore, value); }

        public System.String UpperCutScore  { get => _UpperCutScore; set => SetProperty(ref _UpperCutScore, value); }

        public System.String DescriptiveFeedback  { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            AssessmentSubtestId = model.AssessmentSubtestId;
            ScoreMetric = model.ScoreMetric;
            Label = model.Label;
            LowerCutScore = model.LowerCutScore;
            UpperCutScore = model.UpperCutScore;
            DescriptiveFeedback = model.DescriptiveFeedback;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
