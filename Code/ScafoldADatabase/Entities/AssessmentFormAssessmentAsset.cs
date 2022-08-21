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
    [Table("AssessmentForm_AssessmentAsset")]
    [Index("AssessmentFormId", "AssessmentAssetId", Name = "IX_AssessmentForm_AssessmentAsset", IsUnique = true)]
    public partial class AssessmentFormAssessmentAsset
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("AssessmentForm_AssessmentAssetId")]
        public int AssessmentFormAssessmentAssetId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentForm
        /// </summary>
        public int AssessmentFormId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentAsset
        /// </summary>
        public int AssessmentAssetId { get; set; }
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

        [ForeignKey("AssessmentAssetId")]
        [InverseProperty("AssessmentFormAssessmentAssets")]
        public virtual AssessmentAsset AssessmentAsset { get; set; } = null!;
        [ForeignKey("AssessmentFormId")]
        [InverseProperty("AssessmentFormAssessmentAssets")]
        public virtual AssessmentForm AssessmentForm { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentFormAssessmentAssets")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentFormAssessmentAssets")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
