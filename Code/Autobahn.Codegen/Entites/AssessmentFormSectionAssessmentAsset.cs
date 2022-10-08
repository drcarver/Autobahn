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
    [Table("AssessmentFormSection_AssessmentAsset", Schema = "Assessment")]
    [Index("AssessmentFormSectionId", "AssessmentAssetId", Name = "IX_AssessmentFormSection_AssessmentAsset", IsUnique = true)]
    public partial class AssessmentFormSectionAssessmentAsset
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentFormSectionAssessmentAssetId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentFormSection
        /// </summary>
        public int AssessmentFormSectionId { get; set; }
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
        [InverseProperty("AssessmentFormSectionAssessmentAssets")]
        public virtual AssessmentAsset AssessmentAsset { get; set; } = null!;
        [ForeignKey("AssessmentFormSectionId")]
        [InverseProperty("AssessmentFormSectionAssessmentAssets")]
        public virtual AssessmentFormSection AssessmentFormSection { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentFormSectionAssessmentAssets")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentFormSectionAssessmentAssets")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
