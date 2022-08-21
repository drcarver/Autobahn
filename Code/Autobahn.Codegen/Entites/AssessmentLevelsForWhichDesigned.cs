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
    [Table("AssessmentLevelsForWhichDesigned")]
    [Index("AssessmentId", "RefGradeLevelId", Name = "IX_AssessmentLevelsForWhichDesigned", IsUnique = true)]
    public partial class AssessmentLevelsForWhichDesigned
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentLevelsForWhichDesignedId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// Foreign key - RefGradeLevel
        /// </summary>
        public int RefGradeLevelId { get; set; }
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
        [InverseProperty("AssessmentLevelsForWhichDesigneds")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentLevelsForWhichDesigneds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentLevelsForWhichDesigneds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeLevelId")]
        [InverseProperty("AssessmentLevelsForWhichDesigneds")]
        public virtual RefGradeLevel RefGradeLevel { get; set; } = null!;
    }
}
