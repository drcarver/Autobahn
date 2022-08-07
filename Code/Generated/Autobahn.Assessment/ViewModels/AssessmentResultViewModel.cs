//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentResultViewModel
     /// </summary>
    public partial class AssessmentResultViewModel : ViewModelBase, Interfaces.IAssessmentResultViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult";

        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        // member variable for the RefScoreMetricTypeId property
        private Guid? _RefScoreMetricTypeId;

        // member variable for the PreliminaryIndicator property
        private System.Boolean? _PreliminaryIndicator;

        // member variable for the RefAssessmentPretestOutcomeId property
        private Guid? _RefAssessmentPretestOutcomeId;

        // member variable for the NumberOfResponses property
        private System.Int32? _NumberOfResponses;

        // member variable for the DiagnosticStatement property
        private System.String _DiagnosticStatement;

        // member variable for the DiagnosticStatementSource property
        private System.String _DiagnosticStatementSource;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the DescriptiveFeedbackSource property
        private System.String _DescriptiveFeedbackSource;

        // member variable for the InstructionalRecommendation property
        private System.String _InstructionalRecommendation;

        // member variable for the IncludedInAypCalculation property
        private System.Boolean? _IncludedInAypCalculation;

        // member variable for the DateUpdated property
        private System.DateTime? _DateUpdated;

        // member variable for the DateCreated property
        private System.DateTime? _DateCreated;

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the AssessmentRegistrationId property
        private Guid _AssessmentRegistrationId;

        // member variable for the RefELOutcomeMeasurementLevelId property
        private Guid? _RefELOutcomeMeasurementLevelId;

        // member variable for the RefOutcomeTimePointId property
        private Guid? _RefOutcomeTimePointId;

        // member variable for the AssessmentResultDescriptiveFeedbackDateTime property
        private System.DateTime? _AssessmentResultDescriptiveFeedbackDateTime;

        // member variable for the AssessmentResultScoreStandardError property
        private System.Decimal? _AssessmentResultScoreStandardError;

        // member variable for the RefAssessmentResultDataTypeId property
        private Guid? _RefAssessmentResultDataTypeId;

        // member variable for the RefAssessmentResultScoreTypeId property
        private Guid? _RefAssessmentResultScoreTypeId;

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
        /// The title of the AssessmentResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String ScoreValue  { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricTypeId"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        public System.Boolean? PreliminaryIndicator { get => _PreliminaryIndicator; set => SetProperty(ref _PreliminaryIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcomeId"/> model
        /// </summary>
        public Guid? RefAssessmentPretestOutcomeId { get => _RefAssessmentPretestOutcomeId; set => SetProperty(ref _RefAssessmentPretestOutcomeId, value); }

        public System.Int32? NumberOfResponses { get => _NumberOfResponses; set => SetProperty(ref _NumberOfResponses, value); }

        public System.String DiagnosticStatement  { get => _DiagnosticStatement; set => SetProperty(ref _DiagnosticStatement, value); }

        public System.String DiagnosticStatementSource  { get => _DiagnosticStatementSource; set => SetProperty(ref _DiagnosticStatementSource, value); }

        public System.String DescriptiveFeedback  { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        public System.String DescriptiveFeedbackSource  { get => _DescriptiveFeedbackSource; set => SetProperty(ref _DescriptiveFeedbackSource, value); }

        public System.String InstructionalRecommendation  { get => _InstructionalRecommendation; set => SetProperty(ref _InstructionalRecommendation, value); }

        public System.Boolean? IncludedInAypCalculation { get => _IncludedInAypCalculation; set => SetProperty(ref _IncludedInAypCalculation, value); }

        public System.DateTime? DateUpdated { get => _DateUpdated; set => SetProperty(ref _DateUpdated, value); }

        public System.DateTime? DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevelId"/> model
        /// </summary>
        public Guid? RefELOutcomeMeasurementLevelId { get => _RefELOutcomeMeasurementLevelId; set => SetProperty(ref _RefELOutcomeMeasurementLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePointId"/> model
        /// </summary>
        public Guid? RefOutcomeTimePointId { get => _RefOutcomeTimePointId; set => SetProperty(ref _RefOutcomeTimePointId, value); }

        public System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get => _AssessmentResultDescriptiveFeedbackDateTime; set => SetProperty(ref _AssessmentResultDescriptiveFeedbackDateTime, value); }

        public System.Decimal? AssessmentResultScoreStandardError { get => _AssessmentResultScoreStandardError; set => SetProperty(ref _AssessmentResultScoreStandardError, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentResultDataTypeId { get => _RefAssessmentResultDataTypeId; set => SetProperty(ref _RefAssessmentResultDataTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentResultScoreTypeId { get => _RefAssessmentResultScoreTypeId; set => SetProperty(ref _RefAssessmentResultScoreTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResult model)
        {
            IsBusy = true;
            Id = model.Id;
            ScoreValue = model.ScoreValue;
            RefScoreMetricTypeId = model.RefScoreMetricTypeId;
            PreliminaryIndicator = model.PreliminaryIndicator;
            RefAssessmentPretestOutcomeId = model.RefAssessmentPretestOutcomeId;
            NumberOfResponses = model.NumberOfResponses;
            DiagnosticStatement = model.DiagnosticStatement;
            DiagnosticStatementSource = model.DiagnosticStatementSource;
            DescriptiveFeedback = model.DescriptiveFeedback;
            DescriptiveFeedbackSource = model.DescriptiveFeedbackSource;
            InstructionalRecommendation = model.InstructionalRecommendation;
            IncludedInAypCalculation = model.IncludedInAypCalculation;
            DateUpdated = model.DateUpdated;
            DateCreated = model.DateCreated;
            AssessmentSubtestId = model.AssessmentSubtestId;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            RefELOutcomeMeasurementLevelId = model.RefELOutcomeMeasurementLevelId;
            RefOutcomeTimePointId = model.RefOutcomeTimePointId;
            AssessmentResultDescriptiveFeedbackDateTime = model.AssessmentResultDescriptiveFeedbackDateTime;
            AssessmentResultScoreStandardError = model.AssessmentResultScoreStandardError;
            RefAssessmentResultDataTypeId = model.RefAssessmentResultDataTypeId;
            RefAssessmentResultScoreTypeId = model.RefAssessmentResultScoreTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
