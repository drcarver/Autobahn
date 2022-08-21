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
    [Table("AssessmentItemResponse")]
    public partial class AssessmentItemResponse
    {
        public AssessmentItemResponse()
        {
            AssessmentItemRubricCriterionResults = new HashSet<AssessmentItemRubricCriterionResult>();
            LearnerActions = new HashSet<LearnerAction>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentItemResponseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Value { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? ScoreValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessItemResponseStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProficiencyStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? AidSetUsed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? DescriptiveFeedback { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ScaffoldingItemFlag { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? HintCount { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? HintIncludedAnswer { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? FirstAttemptDuration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? StartTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? SecurityIssue { get; set; }
        /// <summary>
        /// Foreign key - AssessmentItem.
        /// </summary>
        public int AssessmentItemId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentParticipantSession
        /// </summary>
        public int AssessmentParticipantSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("ResultXML")]
        public string? ResultXml { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentItemResponseScoreStatusId { get; set; }
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

        [ForeignKey("AssessmentItemId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual AssessmentItem AssessmentItem { get; set; } = null!;
        [ForeignKey("AssessmentParticipantSessionId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual AssessmentParticipantSession AssessmentParticipantSession { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessItemResponseStatusId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual RefAssessmentItemResponseStatus? RefAssessItemResponseStatus { get; set; }
        [ForeignKey("RefAssessmentItemResponseScoreStatusId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual RefAssessmentItemResponseScoreStatus? RefAssessmentItemResponseScoreStatus { get; set; }
        [ForeignKey("RefProficiencyStatusId")]
        [InverseProperty("AssessmentItemResponses")]
        public virtual RefProficiencyStatus? RefProficiencyStatus { get; set; }
        [InverseProperty("AssessmentItemResponse")]
        public virtual ICollection<AssessmentItemRubricCriterionResult> AssessmentItemRubricCriterionResults { get; set; }
        [InverseProperty("AssessmentItemResponse")]
        public virtual ICollection<LearnerAction> LearnerActions { get; set; }
    }
}
