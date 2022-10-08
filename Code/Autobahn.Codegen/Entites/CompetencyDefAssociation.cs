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
    [Table("CompetencyDefAssociation", Schema = "Competencies")]
    public partial class CompetencyDefAssociation
    {
        [Key]
        public int CompetencyDefAssociationId { get; set; }
        public int CompetencyDefinitionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int AssociatedEntityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? CompetencyDefAssociationIdentifierURI { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? ConnectionCitation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? OriginNodeName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? OriginNodeURI { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? DestinationNodeName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? DestinationNodeURI { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Weight { get; set; }
        public int RefEntityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCompetencyDefAssociationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceCompetencyAlignmentTypeId { get; set; }
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
        [InverseProperty("CompetencyDefAssociations")]
        public virtual CompetencyDefinition CompetencyDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencyDefAssociations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencyDefAssociations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCompetencyDefAssociationTypeId")]
        [InverseProperty("CompetencyDefAssociations")]
        public virtual RefCompetencyDefAssociationType? RefCompetencyDefAssociationType { get; set; }
        [ForeignKey("RefEntityTypeId")]
        [InverseProperty("CompetencyDefAssociations")]
        public virtual RefEntityType RefEntityType { get; set; } = null!;
        [ForeignKey("RefLearningResourceCompetencyAlignmentTypeId")]
        [InverseProperty("CompetencyDefAssociations")]
        public virtual RefLearningResourceCompetencyAlignmentType? RefLearningResourceCompetencyAlignmentType { get; set; }
    }
}
