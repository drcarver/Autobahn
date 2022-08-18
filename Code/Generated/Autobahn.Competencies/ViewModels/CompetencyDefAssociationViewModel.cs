//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationViewModel.cs
//* Name:       Competency Definition Prerequisite Identifier
//* Definition: The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
     /// </summary>
    public partial class CompetencyDefAssociationViewModel : ViewModelBase, Interfaces.ICompetencyDefAssociation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefAssociation";

        // AssociatedEntityId -- (backing property for Competency Definition Prerequisite Identifier)
        private Guid _AssociatedEntityId;

        // CompetencyDefAssociationIdentifierURI -- (backing property for Competency Association Identifier URI)
        private System.String _CompetencyDefAssociationIdentifierURI;

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        // ConnectionCitation -- (backing property for Competency Association Connection Citation)
        private System.String _ConnectionCitation;

        // DestinationNodeName -- (backing property for Competency Association Destination Node Name)
        private System.String _DestinationNodeName;

        // DestinationNodeURI -- (backing property for Competency Association Destination Node URI)
        private System.String _DestinationNodeURI;

        // OriginNodeName -- (backing property for Competency Association Origin Node Name)
        private System.String _OriginNodeName;

        // OriginNodeURI -- (backing property for Competency Association Origin Node URI)
        private System.String _OriginNodeURI;

        // RefCompetencyDefAssociationTypeId -- (backing property for Competency Association Type)
        private Guid? _RefCompetencyDefAssociationTypeId;

        // member variable for the RefEntityTypeId property
        private Guid _RefEntityTypeId;

        // RefLearningResourceCompetencyAlignmentTypeId -- (backing property for Learning Resource Competency Alignment Type)
        private Guid? _RefLearningResourceCompetencyAlignmentTypeId;

        // Weight -- (backing property for Competency Association Weight)
        private System.Decimal? _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Competency Definition Prerequisite Identifier
        /// <para>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </para>
        /// </summary>
        /// </summary>
        public Guid AssociatedEntityId { get => _AssociatedEntityId; set => SetProperty(ref _AssociatedEntityId, value); }

        /// <summary>
        /// Competency Association Identifier URI
        /// <para>
        /// A URI that establishes uniqueness of an association between a competency definition and another competency item or other objects such as learning resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19871">Competency Association Identifier URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CompetencyDefAssociationIdentifierURI { get => _CompetencyDefAssociationIdentifierURI; set => SetProperty(ref _CompetencyDefAssociationIdentifierURI, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        /// <summary>
        /// Competency Association Connection Citation
        /// <para>
        /// Any citation appropriate to evidence the connection between nodes
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20371">Competency Association Connection Citation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ConnectionCitation { get => _ConnectionCitation; set => SetProperty(ref _ConnectionCitation, value); }

        /// <summary>
        /// Competency Association Destination Node Name
        /// <para>
        /// Name of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20372">Competency Association Destination Node Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DestinationNodeName { get => _DestinationNodeName; set => SetProperty(ref _DestinationNodeName, value); }

        /// <summary>
        /// Competency Association Destination Node URI
        /// <para>
        /// URI of the destination node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20373">Competency Association Destination Node URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DestinationNodeURI { get => _DestinationNodeURI; set => SetProperty(ref _DestinationNodeURI, value); }

        /// <summary>
        /// Competency Association Origin Node Name
        /// <para>
        /// Name of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20374">Competency Association Origin Node Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String OriginNodeName { get => _OriginNodeName; set => SetProperty(ref _OriginNodeName, value); }

        /// <summary>
        /// Competency Association Origin Node URI
        /// <para>
        /// URI of the origin node when the Competency Association is used as a connector in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20375">Competency Association Origin Node URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String OriginNodeURI { get => _OriginNodeURI; set => SetProperty(ref _OriginNodeURI, value); }

        /// <summary>
        /// Competency Association Type
        /// <para>
        /// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get => _RefCompetencyDefAssociationTypeId; set => SetProperty(ref _RefCompetencyDefAssociationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntityType"/> model
        /// </summary>
        public Guid RefEntityTypeId { get => _RefEntityTypeId; set => SetProperty(ref _RefEntityTypeId, value); }

        /// <summary>
        /// Learning Resource Competency Alignment Type
        /// <para>
        /// The alignment relationship between the resource and a competency definition object.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceCompetencyAlignmentTypeId { get => _RefLearningResourceCompetencyAlignmentTypeId; set => SetProperty(ref _RefLearningResourceCompetencyAlignmentTypeId, value); }

        /// <summary>
        /// Competency Association Weight
        /// <para>
        /// Indicates the relative significance this connection has for the destination node in a learning map.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20376">Competency Association Weight</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefAssociation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssociatedEntityId = model.AssociatedEntityId; // Competency Definition Prerequisite Identifier
            CompetencyDefAssociationIdentifierURI = model.CompetencyDefAssociationIdentifierURI; // Competency Association Identifier URI
            CompetencyDefinitionId = model.CompetencyDefinitionId; // 
            ConnectionCitation = model.ConnectionCitation; // Competency Association Connection Citation
            DestinationNodeName = model.DestinationNodeName; // Competency Association Destination Node Name
            DestinationNodeURI = model.DestinationNodeURI; // Competency Association Destination Node URI
            OriginNodeName = model.OriginNodeName; // Competency Association Origin Node Name
            OriginNodeURI = model.OriginNodeURI; // Competency Association Origin Node URI
            RefCompetencyDefAssociationTypeId = model.RefCompetencyDefAssociationTypeId; // Competency Association Type
            RefEntityTypeId = model.RefEntityTypeId; // 
            RefLearningResourceCompetencyAlignmentTypeId = model.RefLearningResourceCompetencyAlignmentTypeId; // Learning Resource Competency Alignment Type
            Weight = model.Weight; // Competency Association Weight
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearningResourceCompetencyAlignmentType List
        /// <summary>
        /// The complete Competency Definition Prerequisite Identifier List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceCompetencyAlignmentTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1d18e7cc-d352-4514-95ed-54acc2615de1"), Code="Assesses", Description="Assesses", Definition="The learning resource Assesses the aligned competency.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("0eb47f12-7bee-4fe6-93f2-e1425ab2d1a8"), Code="Teaches", Description="Teaches", Definition="The learning resource Teaches the aligned competency.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2cd9a45f-80aa-48f8-b54e-08a320651f7d"), Code="Requires", Description="Requires", Definition="The learning resource Requires the aligned competency.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("363b4455-a7d7-4eb1-812d-2fa2c8e1254c"), Code="TextComplexity", Description="Text Complexity", Definition="The aligned item specifies the Text Complexity of the learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("879540dc-f8a0-447f-9e0a-30e446e0a2cc"), Code="ReadingLevel", Description="Reading Level", Definition="The aligned item specifies the Reading Level of the learning resource.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8eefe42-d3ac-4aed-b45e-59a50fa62633"), Code="EducationalSubject", Description="Educational Subject", Definition="The aligned item specifies the Educational Subject of the learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("3d95b85b-85fb-4ce2-b660-5a37dc1678af"), Code="EducationLevel", Description="Education Level", Definition="The aligned item specifies the Education Level of the learning resource.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
