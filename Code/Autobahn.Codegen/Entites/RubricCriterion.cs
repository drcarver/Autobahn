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
    [Table("RubricCriterion")]
    public partial class RubricCriterion
    {
        public RubricCriterion()
        {
            CompetencySetRubricCriteria = new HashSet<CompetencySetRubricCriterion>();
            RubricCriterionLevels = new HashSet<RubricCriterionLevel>();
        }

        /// <summary>
        /// Surrogate key.
        /// </summary>
        [Key]
        public int RubricCriterionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Category { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Weight { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? Position { get; set; }
        public int RubricId { get; set; }
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
        [InverseProperty("RubricCriteria")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("RubricCriteria")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricId")]
        [InverseProperty("RubricCriteria")]
        public virtual Rubric Rubric { get; set; } = null!;
        [InverseProperty("RubricCriterion")]
        public virtual ICollection<CompetencySetRubricCriterion> CompetencySetRubricCriteria { get; set; }
        [InverseProperty("RubricCriterion")]
        public virtual ICollection<RubricCriterionLevel> RubricCriterionLevels { get; set; }
    }
}
