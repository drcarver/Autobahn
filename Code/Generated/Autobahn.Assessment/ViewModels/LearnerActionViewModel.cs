//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActionViewModel
     /// </summary>
    public partial class LearnerActionViewModel : ViewModelBase, Interfaces.ILearnerAction
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerAction";

        // member variable for the AssessmentItemResponseId property
        private Guid? _AssessmentItemResponseId;

        // member variable for the RefLearnerActionTypeId property
        private Guid? _RefLearnerActionTypeId;

        // member variable for the Value property
        private System.String _Value;

        // member variable for the LearnerActionDateTime property
        private System.DateTime? _LearnerActionDateTime;

        // member variable for the LearnerActionActorIdentifier property
        private System.String _LearnerActionActorIdentifier;

        // member variable for the LearnerActionObjectDescription property
        private System.String _LearnerActionObjectDescription;

        // member variable for the LearnerActionObjectIdentifier property
        private System.String _LearnerActionObjectIdentifier;

        // member variable for the LearnerActionObjectType property
        private System.String _LearnerActionObjectType;

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
        /// The title of the LearnerActionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponseId"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get => _AssessmentItemResponseId; set => SetProperty(ref _AssessmentItemResponseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionTypeId"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get => _RefLearnerActionTypeId; set => SetProperty(ref _RefLearnerActionTypeId, value); }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.DateTime? LearnerActionDateTime { get => _LearnerActionDateTime; set => SetProperty(ref _LearnerActionDateTime, value); }

        public System.String LearnerActionActorIdentifier  { get => _LearnerActionActorIdentifier; set => SetProperty(ref _LearnerActionActorIdentifier, value); }

        public System.String LearnerActionObjectDescription  { get => _LearnerActionObjectDescription; set => SetProperty(ref _LearnerActionObjectDescription, value); }

        public System.String LearnerActionObjectIdentifier  { get => _LearnerActionObjectIdentifier; set => SetProperty(ref _LearnerActionObjectIdentifier, value); }

        public System.String LearnerActionObjectType  { get => _LearnerActionObjectType; set => SetProperty(ref _LearnerActionObjectType, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerAction model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemResponseId = model.AssessmentItemResponseId;
            RefLearnerActionTypeId = model.RefLearnerActionTypeId;
            Value = model.Value;
            LearnerActionDateTime = model.LearnerActionDateTime;
            LearnerActionActorIdentifier = model.LearnerActionActorIdentifier;
            LearnerActionObjectDescription = model.LearnerActionObjectDescription;
            LearnerActionObjectIdentifier = model.LearnerActionObjectIdentifier;
            LearnerActionObjectType = model.LearnerActionObjectType;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
