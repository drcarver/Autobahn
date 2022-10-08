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
    [Table("Rubric", Schema = "Common")]
    public partial class Rubric
    {
        public Rubric()
        {
            AssessmentItems = new HashSet<AssessmentItem>();
            CompetencySetRubrics = new HashSet<CompetencySetRubric>();
            RubricCriteria = new HashSet<RubricCriterion>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RubricId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? UrlReference { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Description { get; set; }
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
        [InverseProperty("Rubrics")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Rubrics")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("Rubric")]
        public virtual ICollection<AssessmentItem> AssessmentItems { get; set; }
        [InverseProperty("Rubric")]
        public virtual ICollection<CompetencySetRubric> CompetencySetRubrics { get; set; }
        [InverseProperty("Rubric")]
        public virtual ICollection<RubricCriterion> RubricCriteria { get; set; }
    }
}
