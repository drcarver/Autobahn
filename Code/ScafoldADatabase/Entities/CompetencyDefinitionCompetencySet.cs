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
    [Table("CompetencyDefinition_CompetencySet")]
    [Index("CompetencyDefinitionId", "CompetencySetId", Name = "IX_CompetencyFrameworkItem_CompetencySet", IsUnique = true)]
    public partial class CompetencyDefinitionCompetencySet
    {
        [Key]
        [Column("CompetencyDefinition_CompetencySetId")]
        public int CompetencyDefinitionCompetencySetId { get; set; }
        public int CompetencySetId { get; set; }
        public int CompetencyDefinitionId { get; set; }
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
        [InverseProperty("CompetencyDefinitionCompetencySets")]
        public virtual CompetencyDefinition CompetencyDefinition { get; set; } = null!;
        [ForeignKey("CompetencySetId")]
        [InverseProperty("CompetencyDefinitionCompetencySets")]
        public virtual CompetencySet CompetencySet { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencyDefinitionCompetencySets")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencyDefinitionCompetencySets")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
