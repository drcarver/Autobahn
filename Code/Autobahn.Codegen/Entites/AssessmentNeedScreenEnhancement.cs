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
    [Table("AssessmentNeedScreenEnhancement", Schema = "Assessment")]
    public partial class AssessmentNeedScreenEnhancement
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentNeedScreenEnhancementId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfileDisplay
        /// </summary>
        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? InvertColorChoice { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Magnification { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfileScreenEnhancement
        /// </summary>
        public int? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(6)]
        public string? ForegroundColor { get; set; }
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

        [ForeignKey("AssessmentPersonalNeedsProfileDisplayId")]
        [InverseProperty("AssessmentNeedScreenEnhancements")]
        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; } = null!;
        [ForeignKey("AssessmentPersonalNeedsProfileScreenEnhancementId")]
        [InverseProperty("AssessmentNeedScreenEnhancements")]
        public virtual AssessmentPersonalNeedsProfileScreenEnhancement? AssessmentPersonalNeedsProfileScreenEnhancement { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentNeedScreenEnhancements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentNeedScreenEnhancements")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
