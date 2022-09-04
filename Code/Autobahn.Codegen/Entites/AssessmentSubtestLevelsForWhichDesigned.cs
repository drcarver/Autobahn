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
    [Table("AssessmentSubtestLevelsForWhichDesigned")]
    [Index("AssessmentSubTestId", "RefGradeId", Name = "IX_AssessmentSubtestLevelsForWhichDesigned", IsUnique = true)]
    public partial class AssessmentSubtestLevelsForWhichDesigned
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSubtestLevelsForWhichDesignedId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSubtest
        /// </summary>
        public int AssessmentSubTestId { get; set; }
        /// <summary>
        /// Foreign key - RefGradeLevel
        /// </summary>
        public int RefGradeId { get; set; }
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

        [ForeignKey("AssessmentSubTestId")]
        [InverseProperty("AssessmentSubtestLevelsForWhichDesigneds")]
        public virtual AssessmentSubTest AssessmentSubTest { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtestLevelsForWhichDesigneds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtestLevelsForWhichDesigneds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeId")]
        [InverseProperty("AssessmentSubtestLevelsForWhichDesigneds")]
        public virtual RefGradeLevel RefGrade { get; set; } = null!;
    }
}
