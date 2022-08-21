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
    [Table("AssessmentPersonalNeedsProfileDisplay")]
    public partial class AssessmentPersonalNeedsProfileDisplay
    {
        public AssessmentPersonalNeedsProfileDisplay()
        {
            AssessmentNeedApipDisplays = new HashSet<AssessmentNeedApipDisplay>();
            AssessmentNeedBrailles = new HashSet<AssessmentNeedBraille>();
            AssessmentNeedScreenEnhancements = new HashSet<AssessmentNeedScreenEnhancement>();
            AssessmentPersonalNeedScreenReaders = new HashSet<AssessmentPersonalNeedScreenReader>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonalNeedsProfile
        /// </summary>
        public int AssessmentPersonalNeedsProfileId { get; set; }
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
        [InverseProperty("AssessmentPersonalNeedsProfileDisplays")]
        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentPersonalNeedsProfileDisplays")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentPersonalNeedsProfileDisplays")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileDisplay")]
        public virtual ICollection<AssessmentNeedApipDisplay> AssessmentNeedApipDisplays { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileDisplay")]
        public virtual ICollection<AssessmentNeedBraille> AssessmentNeedBrailles { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileDisplay")]
        public virtual ICollection<AssessmentNeedScreenEnhancement> AssessmentNeedScreenEnhancements { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileDisplay")]
        public virtual ICollection<AssessmentPersonalNeedScreenReader> AssessmentPersonalNeedScreenReaders { get; set; }
    }
}
