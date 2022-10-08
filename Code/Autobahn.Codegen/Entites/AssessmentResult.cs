using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("AssessmentResult", Schema = "Assessment")]
    [Index("AssessmentResultId", Name = "IX_AssessmentResultId")]
    public partial class AssessmentResult
    {
        public AssessmentResult()
        {
            AssessmentResultPerformanceLevels = new HashSet<AssessmentResultPerformanceLevel>();
            AssessmentResultRubricCriterionResults = new HashSet<AssessmentResultRubricCriterionResult>();
            CredentialAwardEvidences = new HashSet<CredentialAwardEvidence>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentResultId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(35)]
        public string? ScoreValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefScoreMetricTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? PreliminaryIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentPretestOutcomeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NumberOfResponses { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? DiagnosticStatement { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? DiagnosticStatementSource { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? DescriptiveFeedback { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? DescriptiveFeedbackSource { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? InstructionalRecommendation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? IncludedInAypCalculation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSubtest
        /// </summary>
        public int AssessmentSubtestId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentRegistration
        /// </summary>
        public int AssessmentRegistrationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELOutcomeMeasurementLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefOutcomeTimePointId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? AssessmentResultScoreStandardError { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentResultDataTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentResultScoreTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AssessmentRegistrationId")]
        [InverseProperty("AssessmentResults")]
        public virtual AssessmentRegistration AssessmentRegistration { get; set; } = null!;
        [ForeignKey("AssessmentSubtestId")]
        [InverseProperty("AssessmentResults")]
        public virtual AssessmentSubTest AssessmentSubTest { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentResults")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentResults")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentPretestOutcomeId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefAssessmentPretestOutcome? RefAssessmentPretestOutcome { get; set; }
        [ForeignKey("RefAssessmentResultDataTypeId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefAssessmentResultDataType? RefAssessmentResultDataType { get; set; }
        [ForeignKey("RefAssessmentResultScoreTypeId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefAssessmentResultScoreType? RefAssessmentResultScoreType { get; set; }
        [ForeignKey("RefEloutcomeMeasurementLevelId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefELOutcomeMeasurementLevel? RefEloutcomeMeasurementLevel { get; set; }
        [ForeignKey("RefOutcomeTimePointId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefOutcomeTimePoint? RefOutcomeTimePoint { get; set; }
        [ForeignKey("RefScoreMetricTypeId")]
        [InverseProperty("AssessmentResults")]
        public virtual RefScoreMetricType? RefScoreMetricType { get; set; }
        [InverseProperty("AssessmentResult")]
        public virtual ICollection<AssessmentResultPerformanceLevel> AssessmentResultPerformanceLevels { get; set; }
        [InverseProperty("AssessmentResult")]
        public virtual ICollection<AssessmentResultRubricCriterionResult> AssessmentResultRubricCriterionResults { get; set; }
        [InverseProperty("AssessmentResult")]
        public virtual ICollection<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }
    }
}
