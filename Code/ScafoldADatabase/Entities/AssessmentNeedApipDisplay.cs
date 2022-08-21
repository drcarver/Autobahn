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
    [Table("AssessmentNeedApipDisplay")]
    public partial class AssessmentNeedApipDisplay
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentNeedApipDisplayId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfileDisplay
        /// </summary>
        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? MaskingAssignedSupportIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? MaskingActivateByDefaultIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedMaskingTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? EncouragementAssignedSupportIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? EncouragementActivateByDefaultIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4000)]
        public string? EncouragementTextMessagingString { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? EncouragementSoundFileUrl { get; set; }
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
        [InverseProperty("AssessmentNeedApipDisplays")]
        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentNeedApipDisplays")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentNeedApipDisplays")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedMaskingTypeId")]
        [InverseProperty("AssessmentNeedApipDisplays")]
        public virtual RefAssessmentNeedMaskingType? RefAssessmentNeedMaskingType { get; set; }
    }
}
