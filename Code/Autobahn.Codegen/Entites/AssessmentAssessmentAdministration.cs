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
    [Table("AssessmentAssessmentAdministration", Schema = "Assessment")]
    [Index("AssessmentId", "AssessmentAdministrationId", Name = "IX_Assessment_AssessmentAdministration", IsUnique = true)]
    public partial class AssessmentAssessmentAdministration
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentAssessmentAdministrationId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// Foreign key - Assessment Administration
        /// </summary>
        public int AssessmentAdministrationId { get; set; }
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

        [ForeignKey("AssessmentId")]
        [InverseProperty("AssessmentAssessmentAdministrations")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("AssessmentAdministrationId")]
        [InverseProperty("AssessmentAssessmentAdministrations")]
        public virtual AssessmentAdministration AssessmentAdministration { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentAssessmentAdministrations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentAssessmentAdministrations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
