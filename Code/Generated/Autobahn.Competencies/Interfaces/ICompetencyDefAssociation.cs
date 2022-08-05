//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefAssociation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefAssociation
     /// </summary>
    public partial interface ICompetencyDefAssociation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssociatedEntity"/> model
        /// </summary>
        Guid AssociatedEntityId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.CompetencyDefAssociationIdentifierURI non nullable property
        /// </summary>
        System.String CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.ConnectionCitation non nullable property
        /// </summary>
        System.String ConnectionCitation { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.OriginNodeName non nullable property
        /// </summary>
        System.String OriginNodeName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.OriginNodeURI non nullable property
        /// </summary>
        System.String OriginNodeURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.DestinationNodeName non nullable property
        /// </summary>
        System.String DestinationNodeName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.DestinationNodeURI non nullable property
        /// </summary>
        System.String DestinationNodeURI { get; set; }

        /// <summary>
        /// Defines the CompetencyDefAssociation.Weight nullable property
        /// </summary>
        System.Decimal? Weight { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEntityType"/> model
        /// </summary>
        Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefAssociationType"/> model
        /// </summary>
        Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceCompetencyAlignmentType"/> model
        /// </summary>
        Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

    }
}
