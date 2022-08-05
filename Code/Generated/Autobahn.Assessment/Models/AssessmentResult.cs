//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResult.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentResult
     /// </summary>
    public partial class AssessmentResult : AutobahnBase, Interfaces.IAssessmentResult
    {
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
        /// Defines the AssessmentResult.DiagnosticStatementSource non nullable property
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
        /// Defines the AssessmentResult.InstructionalRecommendation non nullable property
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
        /// Defines the AssessmentResult.AssessmentResultDescriptiveFeedbackDateTime nullable property
        /// </summary>
        public System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentResult.AssessmentResultScoreStandardError nullable property
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
