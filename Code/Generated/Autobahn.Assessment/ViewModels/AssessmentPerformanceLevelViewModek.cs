//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPerformanceLevelViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentPerformanceLevelViewModel : BindableBase, IAssessmentPerformanceLevel
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

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

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid? AssessmentSubtestId { get; set; }

        public System.String ScoreMetric  { get => _ScoreMetric; set => SetProperty(ref _ScoreMetric, value); }

        public System.String Label  { get => _Label; set => SetProperty(ref _Label, value); }

        public System.String LowerCutScore  { get => _LowerCutScore; set => SetProperty(ref _LowerCutScore, value); }

        public System.String UpperCutScore  { get => _UpperCutScore; set => SetProperty(ref _UpperCutScore, value); }

        public System.String DescriptiveFeedback  { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentPerformanceLevel model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
