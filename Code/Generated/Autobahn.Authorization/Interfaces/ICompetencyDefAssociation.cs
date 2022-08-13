//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefAssociation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ICompetencyDefAssociation Interface
     /// </summary>
    public partial interface ICompetencyDefAssociation : IAutobahnBase
    {
        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        Guid AssociatedEntityId { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String ConnectionCitation { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String DestinationNodeName { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String DestinationNodeURI { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String OriginNodeName { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.String OriginNodeURI { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        System.Decimal? Weight { get; set; }

    }
}
