//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResult.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResult
     /// </summary>
    public partial interface IAssessmentResult
    {
        /// <summary>
        /// Defines the AssessmentResult.ScoreValue non nullable property
        /// </summary>
        System.String ScoreValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.PreliminaryIndicator nullable property
        /// </summary>
        System.Boolean? PreliminaryIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPretestOutcome"/> model
        /// </summary>
        Guid? RefAssessmentPretestOutcomeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.NumberOfResponses nullable property
        /// </summary>
        System.Int32? NumberOfResponses { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DiagnosticStatement non nullable property
        /// </summary>
        System.String DiagnosticStatement { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DiagnosticStatementSource non nullable property
        /// </summary>
        System.String DiagnosticStatementSource { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DescriptiveFeedback non nullable property
        /// </summary>
        System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DescriptiveFeedbackSource non nullable property
        /// </summary>
        System.String DescriptiveFeedbackSource { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.InstructionalRecommendation non nullable property
        /// </summary>
        System.String InstructionalRecommendation { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.IncludedInAypCalculation nullable property
        /// </summary>
        System.Boolean? IncludedInAypCalculation { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DateUpdated nullable property
        /// </summary>
        System.DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.DateCreated nullable property
        /// </summary>
        System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOutcomeMeasurementLevel"/> model
        /// </summary>
        Guid? RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutcomeTimePoint"/> model
        /// </summary>
        Guid? RefOutcomeTimePointId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.AssessmentResultDescriptiveFeedbackDateTime nullable property
        /// </summary>
        System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.AssessmentResultScoreStandardError nullable property
        /// </summary>
        System.Decimal? AssessmentResultScoreStandardError { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultDataType"/> model
        /// </summary>
        Guid? RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentResultScoreType"/> model
        /// </summary>
        Guid? RefAssessmentResultScoreTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}