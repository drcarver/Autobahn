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
    [Table("AssessmentNeedApipContent", Schema = "Assessment")]
    public partial class AssessmentNeedApipContent
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentNeedApipContentId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfileContent
        /// </summary>
        public int AssessmentPersonalNeedsProfileContentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? ItemTranslationDisplayLanguageTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? KeywordTranslationLanguageTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedSigningTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ReadAtStartPreferenceIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssessmentNeedDirectionsOnlyIndicator { get; set; }
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

        [ForeignKey("AssessmentPersonalNeedsProfileContentId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual AssessmentPersonalNeedsProfileContent AssessmentPersonalNeedsProfileContent { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ItemTranslationDisplayLanguageTypeId")]
        [InverseProperty("AssessmentNeedApipContentItemTranslationDisplayLanguageTypes")]
        public virtual RefLanguage? ItemTranslationDisplayLanguageType { get; set; }
        [ForeignKey("KeywordTranslationLanguageTypeId")]
        [InverseProperty("AssessmentNeedApipContentKeywordTranslationLanguageTypes")]
        public virtual RefLanguage? KeywordTranslationLanguageType { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedAlternativeRepresentationTypeId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual RefAssessmentNeedAlternativeRepresentationType? RefAssessmentNeedAlternativeRepresentationType { get; set; }
        [ForeignKey("RefAssessmentNeedSigningTypeId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual RefAssessmentNeedSigningType? RefAssessmentNeedSigningType { get; set; }
        [ForeignKey("RefAssessmentNeedSpokenSourcePreferenceTypeId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual RefAssessmentNeedSpokenSourcePreferenceType? RefAssessmentNeedSpokenSourcePreferenceType { get; set; }
        [ForeignKey("RefAssessmentNeedUserSpokenPreferenceTypeId")]
        [InverseProperty("AssessmentNeedApipContents")]
        public virtual RefAssessmentNeedUserSpokenPreferenceType? RefAssessmentNeedUserSpokenPreferenceType { get; set; }
    }
}
