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

        // member variable for the DescriptiveFeedback property
        private  _DescriptiveFeedback;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the Label property
        private  _Label;

        // member variable for the LowerCutScore property
        private  _LowerCutScore;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the ScoreMetric property
        private Guid? _ScoreMetric;

        // member variable for the UpperCutScore property
        private  _UpperCutScore;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  Label { get => _Label; set => SetProperty(ref _Label, value); }

        /// <summary>
        /// </summary>
        public  LowerCutScore { get => _LowerCutScore; set => SetProperty(ref _LowerCutScore, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? ScoreMetric { get => _ScoreMetric; set => SetProperty(ref _ScoreMetric, value); }

        /// <summary>
        /// </summary>
        public  UpperCutScore { get => _UpperCutScore; set => SetProperty(ref _UpperCutScore, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            DescriptiveFeedback = model.DescriptiveFeedback; // 
            Identifier = model.Identifier; // 
            Label = model.Label; // 
            LowerCutScore = model.LowerCutScore; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            ScoreMetric = model.ScoreMetric; // 
            UpperCutScore = model.UpperCutScore; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
