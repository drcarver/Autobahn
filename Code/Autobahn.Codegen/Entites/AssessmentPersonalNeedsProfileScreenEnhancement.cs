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
    [Table("AssessmentPersonalNeedsProfileScreenEnhancement")]
    public partial class AssessmentPersonalNeedsProfileScreenEnhancement
    {
        public AssessmentPersonalNeedsProfileScreenEnhancement()
        {
            AssessmentNeedScreenEnhancements = new HashSet<AssessmentNeedScreenEnhancement>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }
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
        [InverseProperty("AssessmentPersonalNeedsProfileScreenEnhancements")]
        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentPersonalNeedsProfileScreenEnhancements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentPersonalNeedsProfileScreenEnhancements")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfileScreenEnhancement")]
        public virtual ICollection<AssessmentNeedScreenEnhancement> AssessmentNeedScreenEnhancements { get; set; }
    }
}
