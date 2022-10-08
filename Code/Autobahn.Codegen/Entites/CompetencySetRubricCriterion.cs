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
    [Table("CompetencySetRubricCriterion", Schema = "Competencies")]
    public partial class CompetencySetRubricCriterion
    {
        [Key]
        public int CompetencySetRubricCriterionId { get; set; }
        public int CompetencySetId { get; set; }
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

        [ForeignKey("CompetencySetId")]
        [InverseProperty("CompetencySetRubricCriteria")]
        public virtual CompetencySet CompetencySet { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencySetRubricCriteria")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencySetRubricCriteria")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricCriterionId")]
        [InverseProperty("CompetencySetRubricCriteria")]
        public virtual RubricCriterion RubricCriterion { get; set; } = null!;
    }
}
