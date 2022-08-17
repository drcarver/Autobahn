//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefAssociation.cs
//* Name:       Competency Definition Prerequisite Identifier
//* Definition: Learning Standard Item Prerequisite Identifier, Competency Item Prerequisite Identifier
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// Learning Standard Item Prerequisite Identifier, Competency Item Prerequisite Identifier
     /// </summary>
    public partial interface ICompetencyDefAssociation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssociatedEntity"/> model
        /// </summary>
        Guid AssociatedEntityId { get; set; }

        /// <summary>
        /// Competency Association Identifier URI
        /// <para>
        /// A URI that establishes uniqueness of an association between a competency definition and another competency item or other objects such as learning resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19871">Competency Association Identifier URI</a>
        /// </para>
        /// </summary>
        System.String CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Competency Association Connection Citation
        /// <para>
        /// Any citation appropriate to evidence the connection between nodes
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20371">Competency Association Connection Citation</a>
        /// </para>
        /// </summary>
        System.String ConnectionCitation { get; set; }

        /// <summary>
        /// Competency Association Destination Node Name
        /// <para>
        /// Name of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20372">Competency Association Destination Node Name</a>
        /// </para>
        /// </summary>
        System.String DestinationNodeName { get; set; }

        /// <summary>
        /// Competency Association Destination Node URI
        /// <para>
        /// URI of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20373">Competency Association Destination Node URI</a>
        /// </para>
        /// </summary>
        System.String DestinationNodeURI { get; set; }

        /// <summary>
        /// Competency Association Origin Node Name
        /// <para>
        /// Name of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20374">Competency Association Origin Node Name</a>
        /// </para>
        /// </summary>
        System.String OriginNodeName { get; set; }

        /// <summary>
        /// Competency Association Origin Node URI
        /// <para>
        /// URI of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20375">Competency Association Origin Node URI</a>
        /// </para>
        /// </summary>
        System.String OriginNodeURI { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCompetencyDefAssociationType"/> model
        /// </summary>
        Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEntityType"/> model
        /// </summary>
        Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLearningResourceCompetencyAlignmentType"/> model
        /// </summary>
        Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// Competency Association Weight
        /// <para>
        /// Indicates the relative significance this connection has for the destination node in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20376">Competency Association Weight</a>
        /// </para>
        /// </summary>
        System.Decimal? Weight { get; set; }

    }
}
