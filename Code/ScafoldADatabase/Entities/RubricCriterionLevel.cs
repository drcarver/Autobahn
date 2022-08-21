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
    [Table("RubricCriterionLevel")]
    public partial class RubricCriterionLevel
    {
        public RubricCriterionLevel()
        {
            AssessmentItemRubricCriterionResults = new HashSet<AssessmentItemRubricCriterionResult>();
            AssessmentResultRubricCriterionResults = new HashSet<AssessmentResultRubricCriterionResult>();
        }

        /// <summary>
        /// Surrogate key.
        /// </summary>
        [Key]
        public int RubricCriterionLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Quality { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Score { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Feedback { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? Position { get; set; }
        public int RubricCriterionId { get; set; }
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
        [InverseProperty("RubricCriterionLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("RubricCriterionLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricCriterionId")]
        [InverseProperty("RubricCriterionLevels")]
        public virtual RubricCriterion RubricCriterion { get; set; } = null!;
        [InverseProperty("RubricCriterionLevel")]
        public virtual ICollection<AssessmentItemRubricCriterionResult> AssessmentItemRubricCriterionResults { get; set; }
        [InverseProperty("RubricCriterionLevel")]
        public virtual ICollection<AssessmentResultRubricCriterionResult> AssessmentResultRubricCriterionResults { get; set; }
    }
}
