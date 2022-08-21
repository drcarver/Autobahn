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
    [Table("EligibilityEvaluation")]
    public partial class EligibilityEvaluation
    {
        public EligibilityEvaluation()
        {
            IdeaeligibilityEvaluationCategories = new HashSet<IdeaeligibilityEvaluationCategory>();
            IndividualizedProgramEligibilityEvaluations = new HashSet<IndividualizedProgramEligibilityEvaluation>();
        }

        [Key]
        public int EligibilityEvaluationId { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EvaluationDate { get; set; }
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
        [InverseProperty("EligibilityEvaluations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("EligibilityEvaluations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("EligibilityEvaluation")]
        public virtual ICollection<IdeaeligibilityEvaluationCategory> IdeaeligibilityEvaluationCategories { get; set; }
        [InverseProperty("EligibilityEvaluation")]
        public virtual ICollection<IndividualizedProgramEligibilityEvaluation> IndividualizedProgramEligibilityEvaluations { get; set; }
    }
}
