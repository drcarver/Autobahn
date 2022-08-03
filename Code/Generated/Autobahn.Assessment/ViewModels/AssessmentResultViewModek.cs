//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentResultViewModel
     /// </summary>
    public partial class AssessmentResultViewModel : BindableBase, IAssessmentResult
    {
#region "Backing Fields"
        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        // member variable for the PreliminaryIndicator property
        private System.Boolean? _PreliminaryIndicator;

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

        // member variable for the AssessmentResultDescriptiveFeedbackDateTime property
        private System.DateTime? _AssessmentResultDescriptiveFeedbackDateTime;

        // member variable for the AssessmentResultScoreStandardError property
        private System.Decimal? _AssessmentResultScoreStandardError;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String ScoreValue  { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricTypeId"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get; set; }

        public System.Boolean? PreliminaryIndicator { get => _PreliminaryIndicator; set => SetProperty(ref _PreliminaryIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcomeId"/> model
        /// </summary>
        public Guid? RefAssessmentPretestOutcomeId { get; set; }

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
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevelId"/> model
        /// </summary>
        public Guid? RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePointId"/> model
        /// </summary>
        public Guid? RefOutcomeTimePointId { get; set; }

        public System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get => _AssessmentResultDescriptiveFeedbackDateTime; set => SetProperty(ref _AssessmentResultDescriptiveFeedbackDateTime, value); }

        public System.Decimal? AssessmentResultScoreStandardError { get => _AssessmentResultScoreStandardError; set => SetProperty(ref _AssessmentResultScoreStandardError, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentResultScoreTypeId { get; set; }

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
        public void Load(IAssessmentResult model)
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
