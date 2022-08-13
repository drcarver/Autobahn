//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentResultViewModel
     /// </summary>
    public partial class AssessmentResultViewModel : ViewModelBase, Interfaces.IAssessmentResult
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult";

        // member variable for the AssessmentRegistrationId property
        private Guid _AssessmentRegistrationId;

        // member variable for the AssessmentResultDescriptiveFeedbackDateTime property
        private System.DateTime? _AssessmentResultDescriptiveFeedbackDateTime;

        // member variable for the AssessmentResultScoreStandardError property
        private System.Decimal? _AssessmentResultScoreStandardError;

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the DateCreated property
        private System.DateTime? _DateCreated;

        // member variable for the DateUpdated property
        private System.DateTime? _DateUpdated;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the DescriptiveFeedbackSource property
        private System.String _DescriptiveFeedbackSource;

        // member variable for the DiagnosticStatement property
        private System.String _DiagnosticStatement;

        // member variable for the DiagnosticStatementSource property
        private System.String _DiagnosticStatementSource;

        // member variable for the IncludedInAypCalculation property
        private System.Boolean? _IncludedInAypCalculation;

        // member variable for the InstructionalRecommendation property
        private System.String _InstructionalRecommendation;

        // member variable for the NumberOfResponses property
        private System.Int32? _NumberOfResponses;

        // member variable for the PreliminaryIndicator property
        private System.Boolean? _PreliminaryIndicator;

        // member variable for the RefAssessmentPretestOutcomeId property
        private Guid? _RefAssessmentPretestOutcomeId;

        // member variable for the RefAssessmentResultDataTypeId property
        private Guid? _RefAssessmentResultDataTypeId;

        // member variable for the RefAssessmentResultScoreTypeId property
        private Guid? _RefAssessmentResultScoreTypeId;

        // member variable for the RefELOutcomeMeasurementLevelId property
        private Guid? _RefELOutcomeMeasurementLevelId;

        // member variable for the RefOutcomeTimePointId property
        private Guid? _RefOutcomeTimePointId;

        // member variable for the RefScoreMetricTypeId property
        private Guid? _RefScoreMetricTypeId;

        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get => _AssessmentResultDescriptiveFeedbackDateTime; set => SetProperty(ref _AssessmentResultDescriptiveFeedbackDateTime, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.Decimal? AssessmentResultScoreStandardError { get => _AssessmentResultScoreStandardError; set => SetProperty(ref _AssessmentResultScoreStandardError, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.DateTime? DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.DateTime? DateUpdated { get => _DateUpdated; set => SetProperty(ref _DateUpdated, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String DescriptiveFeedbackSource { get => _DescriptiveFeedbackSource; set => SetProperty(ref _DescriptiveFeedbackSource, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String DiagnosticStatement { get => _DiagnosticStatement; set => SetProperty(ref _DiagnosticStatement, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String DiagnosticStatementSource { get => _DiagnosticStatementSource; set => SetProperty(ref _DiagnosticStatementSource, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.Boolean? IncludedInAypCalculation { get => _IncludedInAypCalculation; set => SetProperty(ref _IncludedInAypCalculation, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String InstructionalRecommendation { get => _InstructionalRecommendation; set => SetProperty(ref _InstructionalRecommendation, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.Int32? NumberOfResponses { get => _NumberOfResponses; set => SetProperty(ref _NumberOfResponses, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.Boolean? PreliminaryIndicator { get => _PreliminaryIndicator; set => SetProperty(ref _PreliminaryIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcome"/> model
        /// </summary>
        public Guid? RefAssessmentPretestOutcomeId { get => _RefAssessmentPretestOutcomeId; set => SetProperty(ref _RefAssessmentPretestOutcomeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataType"/> model
        /// </summary>
        public Guid? RefAssessmentResultDataTypeId { get => _RefAssessmentResultDataTypeId; set => SetProperty(ref _RefAssessmentResultDataTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreType"/> model
        /// </summary>
        public Guid? RefAssessmentResultScoreTypeId { get => _RefAssessmentResultScoreTypeId; set => SetProperty(ref _RefAssessmentResultScoreTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevel"/> model
        /// </summary>
        public Guid? RefELOutcomeMeasurementLevelId { get => _RefELOutcomeMeasurementLevelId; set => SetProperty(ref _RefELOutcomeMeasurementLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePoint"/> model
        /// </summary>
        public Guid? RefOutcomeTimePointId { get => _RefOutcomeTimePointId; set => SetProperty(ref _RefOutcomeTimePointId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        public System.String ScoreValue { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResult model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssessmentResultDescriptiveFeedbackDateTime = model.AssessmentResultDescriptiveFeedbackDateTime;
            AssessmentResultScoreStandardError = model.AssessmentResultScoreStandardError;
            AssessmentSubtestId = model.AssessmentSubtestId;
            DateCreated = model.DateCreated;
            DateUpdated = model.DateUpdated;
            DescriptiveFeedback = model.DescriptiveFeedback;
            DescriptiveFeedbackSource = model.DescriptiveFeedbackSource;
            DiagnosticStatement = model.DiagnosticStatement;
            DiagnosticStatementSource = model.DiagnosticStatementSource;
            IncludedInAypCalculation = model.IncludedInAypCalculation;
            InstructionalRecommendation = model.InstructionalRecommendation;
            NumberOfResponses = model.NumberOfResponses;
            PreliminaryIndicator = model.PreliminaryIndicator;
            RefAssessmentPretestOutcomeId = model.RefAssessmentPretestOutcomeId;
            RefAssessmentResultDataTypeId = model.RefAssessmentResultDataTypeId;
            RefAssessmentResultScoreTypeId = model.RefAssessmentResultScoreTypeId;
            RefELOutcomeMeasurementLevelId = model.RefELOutcomeMeasurementLevelId;
            RefOutcomeTimePointId = model.RefOutcomeTimePointId;
            RefScoreMetricTypeId = model.RefScoreMetricTypeId;
            ScoreValue = model.ScoreValue;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
