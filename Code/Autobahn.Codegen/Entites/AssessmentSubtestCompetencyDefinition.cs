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
    [Table("AssessmentSubtestCompetencyDefinition", Schema = "Assessment")]
    [Index("AssessmentSubtestId", "CompetencyDefinitionId", Name = "IX_AssessmentSubtest_CompetencyDefinition", IsUnique = true)]
    public partial class AssessmentSubtestCompetencyDefinition
    {
        [Key]
        public int AssessmentSubtestCompetencyDefinitionId { get; set; }
        public int AssessmentSubTestId { get; set; }
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

        [ForeignKey("AssessmentSubtestId")]
        [InverseProperty("AssessmentSubtestCompetencyDefinitions")]
        public virtual AssessmentSubTest AssessmentSubtest { get; set; } = null!;
        [ForeignKey("CompetencyDefinitionId")]
        [InverseProperty("AssessmentSubtestCompetencyDefinitions")]
        public virtual CompetencyDefinition CompetencyDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtestCompetencyDefinitions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtestCompetencyDefinitions")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
