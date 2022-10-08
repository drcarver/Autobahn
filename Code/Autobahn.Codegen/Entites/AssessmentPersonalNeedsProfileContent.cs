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
    [Table("AssessmentPersonalNeedsProfileContent", Schema = "Assessment")]
    public partial class AssessmentPersonalNeedsProfileContent
    {
        public AssessmentPersonalNeedsProfileContent()
        {
            AssessmentNeedApipContents = new HashSet<AssessmentNeedApipContent>();
            AssessmentPersonalNeedLanguageLearners = new HashSet<AssessmentPersonalNeedLanguageLearner>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentPersonalNeedsProfileContentId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfile
        /// </summary>
        public int AssessmentPersonalNeedsProfileId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedHazardTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefKeywordTranslationsLanguageId { get; set; }
        public bool? KeywordTranslationsAssignedSupportIndicator { get; set; }
        public bool? KeywordTranslationsActivateByDefaultIndicator { get; set; }
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

        [ForeignKey("AssessmentPersonalNeedsProfileId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedHazardTypeId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual RefAssessmentNeedHazardType? RefAssessmentNeedHazardType { get; set; }
        [ForeignKey("RefAssessmentNeedSupportToolId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual RefAssessmentNeedSupportTool? RefAssessmentNeedSupportTool { get; set; }
        [ForeignKey("RefKeywordTranslationsLanguageId")]
        [InverseProperty("AssessmentPersonalNeedsProfileContents")]
        public virtual RefLanguage? RefKeywordTranslationsLanguage { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileContent")]
        public virtual ICollection<AssessmentNeedApipContent> AssessmentNeedApipContents { get; set; }
        [InverseProperty("AssessmentNeedsProfileContent")]
        public virtual ICollection<AssessmentPersonalNeedLanguageLearner> AssessmentPersonalNeedLanguageLearners { get; set; }
    }
}
