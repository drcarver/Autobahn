//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Competencies;

namespace Autobahn.Education.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefAssociation Model
     /// </summary>
    public partial class CompetencyDefAssociationModel : ICompetencyDefAssociation
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region ICompetencyDefAssociation
        /// <summary>
        /// Competency Definition Prerequisite Identifier
        /// <para>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </para>
        /// <para>
        /// <a href="">Competency Definition Prerequisite Identifier</a>
        /// </para>
        /// </summary>
        public Guid AssociatedEntityId { get; set; }

        public System.String CompetencyDefAssociationIdentifierUri { get; set; }

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

        public System.String DestinationNodeUri { get; set; }

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

        public System.String OriginNodeUri { get; set; }

        /// <summary>
        /// Competency Association Type
        /// <para>
        /// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntityType"/> model
        /// </summary>
        public Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Learning Resource Competency Alignment Type
        /// <para>
        /// The alignment relationship between the resource and a competency definition object.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
        /// </para>
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
        public Decimal? Weight { get; set; }

        #endregion
    }
}
