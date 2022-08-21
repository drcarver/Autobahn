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
    [Table("AssessmentAsset")]
    public partial class AssessmentAsset
    {
        public AssessmentAsset()
        {
            AssessmentFormAssessmentAssets = new HashSet<AssessmentFormAssessmentAsset>();
            AssessmentFormSectionAssessmentAssets = new HashSet<AssessmentFormSectionAssessmentAsset>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentAssetId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentAssestIdentifierType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Name { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentAssetTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Owner { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("ContentXML")]
        public string? ContentXml { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? ContentMimeType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? ContentUrl { get; set; }
        /// <summary>
        /// Foreign key - LearningResource.
        /// </summary>
        public int? LearningResourceId { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentAssets")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("AssessmentAssets")]
        public virtual LearningResource? LearningResource { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentAssets")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentAssestIdentifierType")]
        [InverseProperty("AssessmentAssets")]
        public virtual RefAssessmentAssetIdentifierType? RefAssessmentAssestIdentifierTypeNavigation { get; set; }
        [ForeignKey("RefAssessmentAssetTypeId")]
        [InverseProperty("AssessmentAssets")]
        public virtual RefAssessmentAssetType? RefAssessmentAssetType { get; set; }
        [ForeignKey("RefAssessmentLanguageId")]
        [InverseProperty("AssessmentAssets")]
        public virtual RefLanguage? RefAssessmentLanguage { get; set; }
        [InverseProperty("AssessmentAsset")]
        public virtual ICollection<AssessmentFormAssessmentAsset> AssessmentFormAssessmentAssets { get; set; }
        [InverseProperty("AssessmentAsset")]
        public virtual ICollection<AssessmentFormSectionAssessmentAsset> AssessmentFormSectionAssessmentAssets { get; set; }
    }
}
