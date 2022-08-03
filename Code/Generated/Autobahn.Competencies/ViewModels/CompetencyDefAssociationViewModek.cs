//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefAssociationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefAssociationViewModel
     /// </summary>
    public partial class CompetencyDefAssociationViewModel : BindableBase, ICompetencyDefAssociation
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinitionId"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssociatedEntityId"/> model
        /// </summary>
        public Guid AssociatedEntityId { get; set; }

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
        public Guid RefEntityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefAssociationTypeId"/> model
        /// </summary>
        public Guid? RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceCompetencyAlignmentTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(ICompetencyDefAssociation model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
