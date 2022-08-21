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
    [Table("AssessmentPersonalNeedsProfile")]
    public partial class AssessmentPersonalNeedsProfile
    {
        public AssessmentPersonalNeedsProfile()
        {
            AssessmentPersonalNeedsProfileContents = new HashSet<AssessmentPersonalNeedsProfileContent>();
            AssessmentPersonalNeedsProfileControls = new HashSet<AssessmentPersonalNeedsProfileControl>();
            AssessmentPersonalNeedsProfileDisplays = new HashSet<AssessmentPersonalNeedsProfileDisplay>();
            AssessmentPersonalNeedsProfileScreenEnhancements = new HashSet<AssessmentPersonalNeedsProfileScreenEnhancement>();
            PersonAssessmentPersonalNeedsProfiles = new HashSet<PersonAssessmentPersonalNeedsProfile>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentPersonalNeedsProfileId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string AssessmentNeedType { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssignedSupportFlag { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ActivateByDefault { get; set; }
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
        [InverseProperty("AssessmentPersonalNeedsProfiles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentPersonalNeedsProfiles")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfile")]
        public virtual ICollection<AssessmentPersonalNeedsProfileContent> AssessmentPersonalNeedsProfileContents { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfile")]
        public virtual ICollection<AssessmentPersonalNeedsProfileControl> AssessmentPersonalNeedsProfileControls { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfile")]
        public virtual ICollection<AssessmentPersonalNeedsProfileDisplay> AssessmentPersonalNeedsProfileDisplays { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfile")]
        public virtual ICollection<AssessmentPersonalNeedsProfileScreenEnhancement> AssessmentPersonalNeedsProfileScreenEnhancements { get; set; }
        [InverseProperty("AssessmentPersonalNeedsProfile")]
        public virtual ICollection<PersonAssessmentPersonalNeedsProfile> PersonAssessmentPersonalNeedsProfiles { get; set; }
    }
}
