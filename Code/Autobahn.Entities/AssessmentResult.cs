using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentResult")]
    public partial class AssessmentResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentResult()
        {
            AssessmentResult_PerformanceLevel = new HashSet<AssessmentResult_PerformanceLevel>();
            AssessmentResultRubricCriterionResults = new HashSet<AssessmentResultRubricCriterionResult>();
            CredentialAwardEvidences = new HashSet<CredentialAwardEvidence>();
        }

        public int AssessmentResultId { get; set; }

        [StringLength(35)]
        public string ScoreValue { get; set; }

        public int? RefScoreMetricTypeId { get; set; }

        public bool? PreliminaryIndicator { get; set; }

        public int? RefAssessmentPretestOutcomeId { get; set; }

        public int? NumberOfResponses { get; set; }

        public string DiagnosticStatement { get; set; }

        [StringLength(300)]
        public string DiagnosticStatementSource { get; set; }

        [StringLength(300)]
        public string DescriptiveFeedback { get; set; }

        [StringLength(60)]
        public string DescriptiveFeedbackSource { get; set; }

        [StringLength(100)]
        public string InstructionalRecommendation { get; set; }

        public bool? IncludedInAypCalculation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        public int AssessmentSubtestId { get; set; }

        public int AssessmentRegistrationId { get; set; }

        public int? RefELOutcomeMeasurementLevelId { get; set; }

        public int? RefOutcomeTimePointId { get; set; }

        public DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        public decimal? AssessmentResultScoreStandardError { get; set; }

        public int? RefAssessmentResultDataTypeId { get; set; }

        public int? RefAssessmentResultScoreTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentRegistration AssessmentRegistration { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResult_PerformanceLevel> AssessmentResult_PerformanceLevel { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentPretestOutcome RefAssessmentPretestOutcome { get; set; }

        public virtual RefAssessmentResultDataType RefAssessmentResultDataType { get; set; }

        public virtual RefAssessmentResultScoreType RefAssessmentResultScoreType { get; set; }

        public virtual RefELOutcomeMeasurementLevel RefELOutcomeMeasurementLevel { get; set; }

        public virtual RefOutcomeTimePoint RefOutcomeTimePoint { get; set; }

        public virtual RefScoreMetricType RefScoreMetricType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResultRubricCriterionResult> AssessmentResultRubricCriterionResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }
    }
}
