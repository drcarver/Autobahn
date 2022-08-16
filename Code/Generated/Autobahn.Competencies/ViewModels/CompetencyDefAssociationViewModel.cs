//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the AssociatedEntityId property
        private Guid? _AssociatedEntityId;

        // member variable for the CompetencyDefAssociationIdentifierURI property
        private  _CompetencyDefAssociationIdentifierURI;

        // member variable for the ConnectionCitation property
        private  _ConnectionCitation;

        // member variable for the DestinationNodeName property
        private  _DestinationNodeName;

        // member variable for the DestinationNodeURI property
        private  _DestinationNodeURI;

        // member variable for the OriginNodeName property
        private  _OriginNodeName;

        // member variable for the OriginNodeURI property
        private  _OriginNodeURI;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCompetencyDefAssociationTypeId property
        private  _RefCompetencyDefAssociationTypeId;

        // member variable for the RefLearningResourceCompetencyAlignmentTypeId property
        private  _RefLearningResourceCompetencyAlignmentTypeId;

        // member variable for the Weight property
        private  _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssociatedEntity"/> model
        /// </summary>
        public Guid? AssociatedEntityId { get => _AssociatedEntityId; set => SetProperty(ref _AssociatedEntityId, value); }

        /// <summary>
        /// </summary>
        public  CompetencyDefAssociationIdentifierURI { get => _CompetencyDefAssociationIdentifierURI; set => SetProperty(ref _CompetencyDefAssociationIdentifierURI, value); }

        /// <summary>
        /// </summary>
        public  ConnectionCitation { get => _ConnectionCitation; set => SetProperty(ref _ConnectionCitation, value); }

        /// <summary>
        /// </summary>
        public  DestinationNodeName { get => _DestinationNodeName; set => SetProperty(ref _DestinationNodeName, value); }

        /// <summary>
        /// </summary>
        public  DestinationNodeURI { get => _DestinationNodeURI; set => SetProperty(ref _DestinationNodeURI, value); }

        /// <summary>
        /// </summary>
        public  OriginNodeName { get => _OriginNodeName; set => SetProperty(ref _OriginNodeName, value); }

        /// <summary>
        /// </summary>
        public  OriginNodeURI { get => _OriginNodeURI; set => SetProperty(ref _OriginNodeURI, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefAssociationType"/> model
        /// </summary>
        public  RefCompetencyDefAssociationTypeId { get => _RefCompetencyDefAssociationTypeId; set => SetProperty(ref _RefCompetencyDefAssociationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceCompetencyAlignmentType"/> model
        /// </summary>
        public  RefLearningResourceCompetencyAlignmentTypeId { get => _RefLearningResourceCompetencyAlignmentTypeId; set => SetProperty(ref _RefLearningResourceCompetencyAlignmentTypeId, value); }

        /// <summary>
        /// </summary>
        public  Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefAssociation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssociatedEntityId = model.AssociatedEntityId; // 
            CompetencyDefAssociationIdentifierURI = model.CompetencyDefAssociationIdentifierURI; // 
            ConnectionCitation = model.ConnectionCitation; // 
            DestinationNodeName = model.DestinationNodeName; // 
            DestinationNodeURI = model.DestinationNodeURI; // 
            OriginNodeName = model.OriginNodeName; // 
            OriginNodeURI = model.OriginNodeURI; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCompetencyDefAssociationTypeId = model.RefCompetencyDefAssociationTypeId; // 
            RefLearningResourceCompetencyAlignmentTypeId = model.RefLearningResourceCompetencyAlignmentTypeId; // 
            Weight = model.Weight; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
