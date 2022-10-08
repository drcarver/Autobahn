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
    [Table("CompetencySetRubric", Schema = "Competencies")]
    public partial class CompetencySetRubric
    {
        [Key]
        public int CompetencySetRubricId { get; set; }
        public int CompetencySetId { get; set; }
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

        [ForeignKey("CompetencySetId")]
        [InverseProperty("CompetencySetRubrics")]
        public virtual CompetencySet CompetencySet { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencySetRubrics")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencySetRubrics")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricId")]
        [InverseProperty("CompetencySetRubrics")]
        public virtual Rubric Rubric { get; set; } = null!;
    }
}
