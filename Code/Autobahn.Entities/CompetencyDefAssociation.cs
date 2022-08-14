using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencyDefAssociation")]
    public partial class CompetencyDefAssociation
    {
        public int CompetencyDefAssociationId { get; set; }

        public int CompetencyDefinitionId { get; set; }

        public int AssociatedEntityId { get; set; }

        [StringLength(512)]
        public string CompetencyDefAssociationIdentifierURI { get; set; }

        [StringLength(300)]
        public string ConnectionCitation { get; set; }

        [StringLength(30)]
        public string OriginNodeName { get; set; }

        [StringLength(512)]
        public string OriginNodeURI { get; set; }

        [StringLength(30)]
        public string DestinationNodeName { get; set; }

        [StringLength(512)]
        public string DestinationNodeURI { get; set; }

        public decimal? Weight { get; set; }

        public int RefEntityTypeId { get; set; }

        public int? RefCompetencyDefAssociationTypeId { get; set; }

        public int? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual RefCompetencyDefAssociationType RefCompetencyDefAssociationType { get; set; }

        public virtual CompetencyDefinition CompetencyDefinition { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEntityType RefEntityType { get; set; }

        public virtual RefLearningResourceCompetencyAlignmentType RefLearningResourceCompetencyAlignmentType { get; set; }
    }
}
