//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefAssociationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefAssociationViewModel
     /// </summary>
    public partial class CompetencyDefAssociationViewModel : ViewModelBase, Interfaces.ICompetencyDefAssociation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefAssociation";

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        // member variable for the AssociatedEntityId property
        private Guid _AssociatedEntityId;

        // member variable for the CompetencyDefAssociationIdentifierURI property
        private System.String _CompetencyDefAssociationIdentifierURI;

        // member variable for the ConnectionCitation property
        private System.String _ConnectionCitation;

        // member variable for the OriginNodeName property
        private System.String _OriginNodeName;

        // member variable for the OriginNodeURI property
        private System.String _OriginNodeURI;

        // member variable for the DestinationNodeName property
        private System.String _DestinationNodeName;

        // member variable for the DestinationNodeURI property
        private System.String _DestinationNodeURI;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        // member variable for the RefEntityTypeId property
        private Guid _RefEntityTypeId;

        // member variable for the RefCompetencyDefAssociationTypeId property
        private Guid? _RefCompetencyDefAssociationTypeId;

        // member variable for the RefLearningResourceCompetencyAlignmentTypeId property
        private Guid? _RefLearningResourceCompetencyAlignmentTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefAssociationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinitionId"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssociatedEntityId"/> model
        /// </summary>
        public Guid AssociatedEntityId { get => _AssociatedEntityId; set => SetProperty(ref _AssociatedEntityId, value); }

        public System.String CompetencyDefAssociationIdentifierURI  { get => _CompetencyDefAssociationIdentifierURI; set => SetProperty(ref _CompetencyDefAssociationIdentifierURI, value); }

        public System.String ConnectionCitation  { get => _ConnectionCitation; set => SetProperty(ref _ConnectionCitation, value); }

        public System.String OriginNodeName  { get => _OriginNodeName; set => SetProperty(ref _OriginNodeName, value); }

        public System.String OriginNodeURI  { get => _OriginNodeURI; set => SetProperty(ref _OriginNodeURI, value); }

        public System.String DestinationNodeName  { get => _DestinationNodeName; set => SetProperty(ref _DestinationNodeName, value); }

        public System.String DestinationNodeURI  { get => _DestinationNodeURI; set => SetProperty(ref _DestinationNodeURI, value); }

        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEntityTypeId"/> model
        /// </summary>
        public Guid RefEntityTypeId { get => _RefEntityTypeId; set => SetProperty(ref _RefEntityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefAssociationTypeId"/> model
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get => _RefCompetencyDefAssociationTypeId; set => SetProperty(ref _RefCompetencyDefAssociationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceCompetencyAlignmentTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceCompetencyAlignmentTypeId { get => _RefLearningResourceCompetencyAlignmentTypeId; set => SetProperty(ref _RefLearningResourceCompetencyAlignmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefAssociation model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyDefinitionId = model.CompetencyDefinitionId;
            AssociatedEntityId = model.AssociatedEntityId;
            CompetencyDefAssociationIdentifierURI = model.CompetencyDefAssociationIdentifierURI;
            ConnectionCitation = model.ConnectionCitation;
            OriginNodeName = model.OriginNodeName;
            OriginNodeURI = model.OriginNodeURI;
            DestinationNodeName = model.DestinationNodeName;
            DestinationNodeURI = model.DestinationNodeURI;
            Weight = model.Weight;
            RefEntityTypeId = model.RefEntityTypeId;
            RefCompetencyDefAssociationTypeId = model.RefCompetencyDefAssociationTypeId;
            RefLearningResourceCompetencyAlignmentTypeId = model.RefLearningResourceCompetencyAlignmentTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
