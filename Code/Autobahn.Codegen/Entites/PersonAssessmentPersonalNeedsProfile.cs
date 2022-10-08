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
    [Table("PersonAssessmentPersonalNeedsProfile", Schema = "Person")]
    [Index("PersonId", "AssessmentPersonalNeedsProfileId", Name = "IX_Person_AssessmentPersonalNeedsProfile", IsUnique = true)]
    public partial class PersonAssessmentPersonalNeedsProfile
    {
        [Key]
        public int PersonAssessmentPersonalNeedsProfileId { get; set; }
        public int PersonId { get; set; }
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
        [InverseProperty("PersonAssessmentPersonalNeedsProfiles")]
        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonAssessmentPersonalNeedsProfiles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonAssessmentPersonalNeedsProfiles")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonAssessmentPersonalNeedsProfiles")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
