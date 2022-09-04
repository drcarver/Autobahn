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
    [Table("AssessmentItemApipDescription")]
    public partial class AssessmentItemApipDescription
    {
        [Key]
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
        public int? RefKeywordTranslationLanguageId { get; set; }
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

        [ForeignKey("AssessmentItemApipId")]
        [InverseProperty("AssessmentItemApipDescriptions")]
        public virtual AssessmentItemApip AssessmentItemApip { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentItemApipDescriptions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentItemApipDescriptions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefKeywordTranslationLanguageId")]
        [InverseProperty("AssessmentItemApipDescriptions")]
        public virtual RefLanguage? RefKeywordTranslationLanguage { get; set; }
    }
}
