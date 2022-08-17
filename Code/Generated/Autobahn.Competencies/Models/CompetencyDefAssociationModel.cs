//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationModel.cs
//* Name:       Competency Definition Prerequisite Identifier
//* Definition: The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
     /// </summary>
    public partial class CompetencyDefAssociationModel : AutobahnBase, Interfaces.ICompetencyDefAssociation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssociatedEntity"/> model
        /// </summary>
        public Guid AssociatedEntityId { get; set; }

        /// <summary>
        /// Competency Association Identifier URI
        /// <para>
        /// A URI that establishes uniqueness of an association between a competency definition and another competency item or other objects such as learning resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19871">Competency Association Identifier URI</a>
        /// </para>
        /// </summary>
        public System.String CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Competency Association Connection Citation
        /// <para>
        /// Any citation appropriate to evidence the connection between nodes
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20371">Competency Association Connection Citation</a>
        /// </para>
        /// </summary>
        public System.String ConnectionCitation { get; set; }

        /// <summary>
        /// Competency Association Destination Node Name
        /// <para>
        /// Name of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20372">Competency Association Destination Node Name</a>
        /// </para>
        /// </summary>
        public System.String DestinationNodeName { get; set; }

        /// <summary>
        /// Competency Association Destination Node URI
        /// <para>
        /// URI of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20373">Competency Association Destination Node URI</a>
        /// </para>
        /// </summary>
        public System.String DestinationNodeURI { get; set; }

        /// <summary>
        /// Competency Association Origin Node Name
        /// <para>
        /// Name of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20374">Competency Association Origin Node Name</a>
        /// </para>
        /// </summary>
        public System.String OriginNodeName { get; set; }

        /// <summary>
        /// Competency Association Origin Node URI
        /// <para>
        /// URI of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20375">Competency Association Origin Node URI</a>
        /// </para>
        /// </summary>
        public System.String OriginNodeURI { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCompetencyDefAssociationType"/> model
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEntityType"/> model
        /// </summary>
        public Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLearningResourceCompetencyAlignmentType"/> model
        /// </summary>
        public Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// Competency Association Weight
        /// <para>
        /// Indicates the relative significance this connection has for the destination node in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20376">Competency Association Weight</a>
        /// </para>
        /// </summary>
        public System.Decimal? Weight { get; set; }

    }
}
