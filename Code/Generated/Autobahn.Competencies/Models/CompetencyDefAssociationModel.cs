//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefAssociationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefAssociation Model
     /// </summary>
    public partial class CompetencyDefAssociationModel : AutobahnBase, Interfaces.ICompetencyDefAssociationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssociatedEntity"/> model
        /// </summary>
        public Guid AssociatedEntityId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.CompetencyDefAssociationIdentifierURI non nullable property
        /// </summary>
        public System.String CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.ConnectionCitation non nullable property
        /// </summary>
        public System.String ConnectionCitation { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.OriginNodeName non nullable property
        /// </summary>
        public System.String OriginNodeName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.OriginNodeURI non nullable property
        /// </summary>
        public System.String OriginNodeURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.DestinationNodeName non nullable property
        /// </summary>
        public System.String DestinationNodeName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.DestinationNodeURI non nullable property
        /// </summary>
        public System.String DestinationNodeURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.Weight nullable property
        /// </summary>
        public System.Decimal? Weight { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEntityType"/> model
        /// </summary>
        public Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefAssociationType"/> model
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceCompetencyAlignmentType"/> model
        /// </summary>
        public Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
