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
    [Table("AssessmentResultRubricCriterionResult")]
    [Index("AssessmentResultId", "RubricCriterionLevelId", Name = "IX_AssessmentResult_RubricCriterionLevel", IsUnique = true)]
    public partial class AssessmentResultRubricCriterionResult
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentResultRubricCriterionResultId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentResult.
        /// </summary>
        public int AssessmentResultId { get; set; }
        /// <summary>
        /// Foreign key - RubricCriterionLevel.
        /// </summary>
        public int RubricCriterionLevelId { get; set; }
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

        [ForeignKey("AssessmentResultId")]
        [InverseProperty("AssessmentResultRubricCriterionResults")]
        public virtual AssessmentResult AssessmentResult { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentResultRubricCriterionResults")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentResultRubricCriterionResults")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricCriterionLevelId")]
        [InverseProperty("AssessmentResultRubricCriterionResults")]
        public virtual RubricCriterionLevel RubricCriterionLevel { get; set; } = null!;
    }
}
