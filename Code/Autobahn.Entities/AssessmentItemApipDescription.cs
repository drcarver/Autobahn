using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemApipDescription")]
    public partial class AssessmentItemApipDescription
    {
        public int AssessmentItemApipDescriptionId { get; set; }

        public int AssessmentItemApipId { get; set; }

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

        public bool? KeywordTranslationsAssignedSupportIndicator { get; set; }

        public bool? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        public bool? BrailleIndicator { get; set; }

        public bool? TextOnlyIndicator { get; set; }

        public bool? TextOnlyOnDemandIndicator { get; set; }

        public bool? TextGraphicsIndicator { get; set; }

        public bool? GraphicsOnlyIndicator { get; set; }

        public bool? NonVisualIndicator { get; set; }

        public bool? AslIndicator { get; set; }

        public bool? AslOnDemandIndicator { get; set; }

        public bool? SignedEnglishIndicator { get; set; }

        public bool? SignedEnglishOnDemandIndicator { get; set; }

        public int? RefHazardTypeId { get; set; }

        public int? RefSupportToolTypeId { get; set; }

        public int? RefKeywordTranslationLanguageId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItemApip AssessmentItemApip { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }
    }
}
