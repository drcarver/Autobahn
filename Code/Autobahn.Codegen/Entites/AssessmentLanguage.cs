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
    [Table("AssessmentLanguage")]
    [Index("AssessmentId", "RefLanguageId", Name = "IX_AssessmentLanguage", IsUnique = true)]
    public partial class AssessmentLanguage
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentLanguageId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// Foreign key - RefLanguage
        /// </summary>
        public int RefLanguageId { get; set; }
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
        [InverseProperty("AssessmentLanguages")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentLanguages")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentLanguages")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefLanguageId")]
        [InverseProperty("AssessmentLanguages")]
        public virtual RefLanguage RefLanguage { get; set; } = null!;
    }
}
