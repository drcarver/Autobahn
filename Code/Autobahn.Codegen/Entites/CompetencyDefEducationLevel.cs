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
    [Table("CompetencyDefEducationLevel", Schema = "Competencies")]
    [Index("CompetencyDefinitionId", "RefEducationLevelId", Name = "IX_CompetencyFrameworkItem_RefEducationLevel", IsUnique = true)]
    public partial class CompetencyDefEducationLevel
    {
        [Key]
        public int CompetencyDefEducationLevelId { get; set; }
        public int CompetencyDefinitionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefEducationLevelId { get; set; }
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

        [ForeignKey("CompetencyDefinitionId")]
        [InverseProperty("CompetencyDefEducationLevels")]
        public virtual CompetencyDefinition CompetencyDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencyDefEducationLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencyDefEducationLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEducationLevelId")]
        [InverseProperty("CompetencyDefEducationLevels")]
        public virtual RefEducationLevel RefEducationLevel { get; set; } = null!;
    }
}
