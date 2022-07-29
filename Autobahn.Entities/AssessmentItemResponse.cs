using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemResponse")]
    public partial class AssessmentItemResponse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentItemResponse()
        {
            AssessmentItemRubricCriterionResults = new HashSet<AssessmentItemRubricCriterionResult>();
            LearnerActions = new HashSet<LearnerAction>();
        }

        public int AssessmentItemResponseId { get; set; }

        [StringLength(300)]
        public string Value { get; set; }

        [StringLength(60)]
        public string ScoreValue { get; set; }

        public int? RefAssessItemResponseStatusId { get; set; }

        public int? RefProficiencyStatusId { get; set; }

        [StringLength(30)]
        public string AidSetUsed { get; set; }

        [StringLength(300)]
        public string DescriptiveFeedback { get; set; }

        public bool? ScaffoldingItemFlag { get; set; }

        public int? HintCount { get; set; }

        public bool? HintIncludedAnswer { get; set; }

        public TimeSpan? Duration { get; set; }

        public TimeSpan? FirstAttemptDuration { get; set; }

        public TimeSpan? StartTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [StringLength(300)]
        public string SecurityIssue { get; set; }

        public int AssessmentItemId { get; set; }

        public int AssessmentParticipantSessionId { get; set; }

        public string ResultXML { get; set; }

        public DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        public int? RefAssessmentItemResponseScoreStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemRubricCriterionResult> AssessmentItemRubricCriterionResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerAction> LearnerActions { get; set; }

        public virtual AssessmentParticipantSession AssessmentParticipantSession { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentItemResponseStatu RefAssessmentItemResponseStatu { get; set; }

        public virtual RefAssessmentItemResponseScoreStatu RefAssessmentItemResponseScoreStatu { get; set; }

        public virtual RefProficiencyStatu RefProficiencyStatu { get; set; }
    }
}
