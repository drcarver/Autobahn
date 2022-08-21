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
    [Table("AssessmentNeedApipControl")]
    public partial class AssessmentNeedApipControl
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentNeedApipControlId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfileControl
        /// </summary>
        public int AssessmentPersonalNeedsProfileControlId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(9)]
        public string? AssessmentNeedTimeMultiplier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(6)]
        public string? LineReaderHighlightColor { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(6)]
        public string? OverlayColor { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(6)]
        public string? BackgroundColor { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }
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

        [ForeignKey("AssessmentPersonalNeedsProfileControlId")]
        [InverseProperty("AssessmentNeedApipControls")]
        public virtual AssessmentPersonalNeedsProfileControl AssessmentPersonalNeedsProfileControl { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentNeedApipControls")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentNeedApipControls")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedIncreasedWhitespacingTypeId")]
        [InverseProperty("AssessmentNeedApipControls")]
        public virtual RefAssessmentNeedIncreasedWhitespacingType? RefAssessmentNeedIncreasedWhitespacingType { get; set; }
    }
}
