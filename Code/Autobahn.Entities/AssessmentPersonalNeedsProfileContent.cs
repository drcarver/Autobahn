using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentPersonalNeedsProfileContent")]
    public partial class AssessmentPersonalNeedsProfileContent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentPersonalNeedsProfileContent()
        {
            AssessmentNeedApipContents = new HashSet<AssessmentNeedApipContent>();
            AssessmentPersonalNeedLanguageLearners = new HashSet<AssessmentPersonalNeedLanguageLearner>();
        }

        public int AssessmentPersonalNeedsProfileContentId { get; set; }

        public int AssessmentPersonalNeedsProfileId { get; set; }

        public int? RefAssessmentNeedHazardTypeId { get; set; }

        public int? RefAssessmentNeedSupportToolId { get; set; }

        public bool? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        public bool? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        public bool? ScaffoldingAssignedSupportIndicator { get; set; }

        public bool? ScaffoldingActivateByDefaultIndicator { get; set; }

        public bool? ChunkingAssignedSupportIndicator { get; set; }

        public bool? ChunkingActivateByDefaultIndicator { get; set; }

        public bool? KeywordEmphasisAssignedSupportIndicator { get; set; }

        public bool? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        public bool? ReducedAnswersAssignedSupportIndicator { get; set; }

        public bool? ReducedAnswersActivateByDefaultIndicator { get; set; }

        public bool? NegativesRemovedAssignedSupportIndicator { get; set; }

        public bool? NegativesRemovedActivateByDefaultIndicator { get; set; }

        public int? RefKeywordTranslationsLanguageId { get; set; }

        public bool? KeywordTranslationsAssignedSupportIndicator { get; set; }

        public bool? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentNeedApipContent> AssessmentNeedApipContents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentPersonalNeedLanguageLearner> AssessmentPersonalNeedLanguageLearners { get; set; }

        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; }

        public virtual RefAssessmentNeedSupportTool RefAssessmentNeedSupportTool { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentNeedHazardType RefAssessmentNeedHazardType { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }
    }
}
