//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   AssessmentResult.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResult
     /// </summary>
    public partial class AssessmentResult : IAssessmentResult
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.ScoreValue non nullable property
        /// </summary>
        public System.String ScoreValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.PreliminaryIndicator nullable property
        /// </summary>
        public System.Boolean? PreliminaryIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcome"/> model
        /// </summary>
        public Guid? RefAssessmentPretestOutcomeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.NumberOfResponses nullable property
        /// </summary>
        public System.Int32? NumberOfResponses { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DiagnosticStatement non nullable property
        /// </summary>
        public System.String DiagnosticStatement { get; set; }

        /// <summary>
        /// Identifies the source of the Diagnostic Statement based on a scored/evaluated portion of an assessment.
        /// </summary>
    public System.String DiagnosticStatementSource { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DescriptiveFeedback non nullable property
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DescriptiveFeedbackSource non nullable property
        /// </summary>
        public System.String DescriptiveFeedbackSource { get; set; }

        /// <summary>
        /// This provides the next steps for instruction for the student based upon the assessment results and student characteristics.
        /// </summary>
    public System.String InstructionalRecommendation { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.IncludedInAypCalculation nullable property
        /// </summary>
        public System.Boolean? IncludedInAypCalculation { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DateUpdated nullable property
        /// </summary>
        public System.DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DateCreated nullable property
        /// </summary>
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevel"/> model
        /// </summary>
        public Guid? RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePoint"/> model
        /// </summary>
        public Guid? RefOutcomeTimePointId { get; set; }

        /// <summary>
        /// The date and time the descriptive feedback was entered for a scored/evaluated portion of an assessment.
        /// </summary>
    public System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// The measure of sampling variability and measurement error for the score, the amount of error to be expected in the score.
        /// </summary>
    public System.Decimal? AssessmentResultScoreStandardError { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataType"/> model
        /// </summary>
        public Guid? RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreType"/> model
        /// </summary>
        public Guid? RefAssessmentResultScoreTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
