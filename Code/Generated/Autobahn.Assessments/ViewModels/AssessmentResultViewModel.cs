//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentResultViewModel
     /// </summary>
    public partial class AssessmentResultViewModel : ViewModelBase, Interfaces.IAssessmentResult
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult";

        // member variable for the AssessmentResultDescriptiveFeedbackDateTime property
        private  _AssessmentResultDescriptiveFeedbackDateTime;

        // member variable for the AssessmentResultScoreStandardError property
        private  _AssessmentResultScoreStandardError;

        // member variable for the DateCreated property
        private  _DateCreated;

        // member variable for the DateUpdated property
        private  _DateUpdated;

        // member variable for the DescriptiveFeedback property
        private  _DescriptiveFeedback;

        // member variable for the DescriptiveFeedbackSource property
        private  _DescriptiveFeedbackSource;

        // member variable for the DiagnosticStatement property
        private  _DiagnosticStatement;

        // member variable for the DiagnosticStatementSource property
        private  _DiagnosticStatementSource;

        // member variable for the InstructionalRecommendation property
        private  _InstructionalRecommendation;

        // member variable for the NumberOfResponses property
        private  _NumberOfResponses;

        // member variable for the PreliminaryIndicator property
        private  _PreliminaryIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentPretestOutcomeId property
        private  _RefAssessmentPretestOutcomeId;

        // member variable for the RefAssessmentResultDataTypeId property
        private  _RefAssessmentResultDataTypeId;

        // member variable for the RefAssessmentResultScoreTypeId property
        private  _RefAssessmentResultScoreTypeId;

        // member variable for the RefELOutcomeMeasurementLevelId property
        private  _RefELOutcomeMeasurementLevelId;

        // member variable for the RefOutcomeTimePointId property
        private  _RefOutcomeTimePointId;

        // member variable for the RefScoreMetricTypeId property
        private  _RefScoreMetricTypeId;

        // member variable for the ScoreValue property
        private Guid? _ScoreValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentResultDescriptiveFeedbackDateTime { get => _AssessmentResultDescriptiveFeedbackDateTime; set => SetProperty(ref _AssessmentResultDescriptiveFeedbackDateTime, value); }

        /// <summary>
        /// </summary>
        public  AssessmentResultScoreStandardError { get => _AssessmentResultScoreStandardError; set => SetProperty(ref _AssessmentResultScoreStandardError, value); }

        /// <summary>
        /// </summary>
        public  DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// </summary>
        public  DateUpdated { get => _DateUpdated; set => SetProperty(ref _DateUpdated, value); }

        /// <summary>
        /// </summary>
        public  DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// </summary>
        public  DescriptiveFeedbackSource { get => _DescriptiveFeedbackSource; set => SetProperty(ref _DescriptiveFeedbackSource, value); }

        /// <summary>
        /// </summary>
        public  DiagnosticStatement { get => _DiagnosticStatement; set => SetProperty(ref _DiagnosticStatement, value); }

        /// <summary>
        /// </summary>
        public  DiagnosticStatementSource { get => _DiagnosticStatementSource; set => SetProperty(ref _DiagnosticStatementSource, value); }

        /// <summary>
        /// </summary>
        public  InstructionalRecommendation { get => _InstructionalRecommendation; set => SetProperty(ref _InstructionalRecommendation, value); }

        /// <summary>
        /// </summary>
        public  NumberOfResponses { get => _NumberOfResponses; set => SetProperty(ref _NumberOfResponses, value); }

        /// <summary>
        /// </summary>
        public  PreliminaryIndicator { get => _PreliminaryIndicator; set => SetProperty(ref _PreliminaryIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcome"/> model
        /// </summary>
        public  RefAssessmentPretestOutcomeId { get => _RefAssessmentPretestOutcomeId; set => SetProperty(ref _RefAssessmentPretestOutcomeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataType"/> model
        /// </summary>
        public  RefAssessmentResultDataTypeId { get => _RefAssessmentResultDataTypeId; set => SetProperty(ref _RefAssessmentResultDataTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreType"/> model
        /// </summary>
        public  RefAssessmentResultScoreTypeId { get => _RefAssessmentResultScoreTypeId; set => SetProperty(ref _RefAssessmentResultScoreTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevel"/> model
        /// </summary>
        public  RefELOutcomeMeasurementLevelId { get => _RefELOutcomeMeasurementLevelId; set => SetProperty(ref _RefELOutcomeMeasurementLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePoint"/> model
        /// </summary>
        public  RefOutcomeTimePointId { get => _RefOutcomeTimePointId; set => SetProperty(ref _RefOutcomeTimePointId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public  RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        /// <summary>
        /// </summary>
        public Guid? ScoreValue { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResult model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentResultDescriptiveFeedbackDateTime = model.AssessmentResultDescriptiveFeedbackDateTime; // 
            AssessmentResultScoreStandardError = model.AssessmentResultScoreStandardError; // 
            DateCreated = model.DateCreated; // 
            DateUpdated = model.DateUpdated; // 
            DescriptiveFeedback = model.DescriptiveFeedback; // 
            DescriptiveFeedbackSource = model.DescriptiveFeedbackSource; // 
            DiagnosticStatement = model.DiagnosticStatement; // 
            DiagnosticStatementSource = model.DiagnosticStatementSource; // 
            InstructionalRecommendation = model.InstructionalRecommendation; // 
            NumberOfResponses = model.NumberOfResponses; // 
            PreliminaryIndicator = model.PreliminaryIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentPretestOutcomeId = model.RefAssessmentPretestOutcomeId; // 
            RefAssessmentResultDataTypeId = model.RefAssessmentResultDataTypeId; // 
            RefAssessmentResultScoreTypeId = model.RefAssessmentResultScoreTypeId; // 
            RefELOutcomeMeasurementLevelId = model.RefELOutcomeMeasurementLevelId; // 
            RefOutcomeTimePointId = model.RefOutcomeTimePointId; // 
            RefScoreMetricTypeId = model.RefScoreMetricTypeId; // 
            ScoreValue = model.ScoreValue; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
