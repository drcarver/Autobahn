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
    [Table("IDEAEligibilityEvaluationCategory")]
    [Index("EligibilityEvaluationId", "RefIdeaeligibilityEvaluationCategoryId", Name = "IX_EligibilityEvaluation_RefIDEAEligibilityEvaluationCategory", IsUnique = true)]
    public partial class IdeaeligibilityEvaluationCategory
    {
        [Key]
        [Column("IDEAEligibilityEvaluationCategoryId")]
        public int IdeaeligibilityEvaluationCategoryId { get; set; }
        public int EligibilityEvaluationId { get; set; }
        [Column("RefIDEAEligibilityEvaluationCategoryId")]
        public int RefIdeaeligibilityEvaluationCategoryId { get; set; }
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
        [InverseProperty("IdeaeligibilityEvaluationCategories")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("EligibilityEvaluationId")]
        [InverseProperty("IdeaeligibilityEvaluationCategories")]
        public virtual EligibilityEvaluation EligibilityEvaluation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IdeaeligibilityEvaluationCategories")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIdeaeligibilityEvaluationCategoryId")]
        [InverseProperty("IdeaeligibilityEvaluationCategories")]
        public virtual RefIdeaeligibilityEvaluationCategory RefIdeaeligibilityEvaluationCategory { get; set; } = null!;
    }
}
