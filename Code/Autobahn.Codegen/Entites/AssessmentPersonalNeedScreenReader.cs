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
    [Table("AssessmentPersonalNeedScreenReader")]
    public partial class AssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentPersonalNeedScreenReaderId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonnalNeedsProfileDisplay
        /// </summary>
        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedUsageTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? SpeechRate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Pitch { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Volume { get; set; }
        public int? RefAssessmentNeedLinkIndicationTypeId { get; set; }
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
        [InverseProperty("AssessmentPersonalNeedScreenReaders")]
        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentPersonalNeedScreenReaders")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentPersonalNeedScreenReaders")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedLinkIndicationTypeId")]
        [InverseProperty("AssessmentPersonalNeedScreenReaders")]
        public virtual RefAssessmentNeedLinkIndicationType? RefAssessmentNeedLinkIndicationType { get; set; }
        [ForeignKey("RefAssessmentNeedUsageTypeId")]
        [InverseProperty("AssessmentPersonalNeedScreenReaders")]
        public virtual RefAssessmentNeedUsageType? RefAssessmentNeedUsageType { get; set; }
    }
}
