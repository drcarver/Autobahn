//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
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

        // member variable for the LearnerActionActorIdentifier property
        private System.String _LearnerActionActorIdentifier;

        // member variable for the LearnerActionDateTime property
        private System.DateTime? _LearnerActionDateTime;

        // member variable for the LearnerActionObjectDescription property
        private System.String _LearnerActionObjectDescription;

        // member variable for the LearnerActionObjectIdentifier property
        private System.String _LearnerActionObjectIdentifier;

        // member variable for the LearnerActionObjectType property
        private System.String _LearnerActionObjectType;

        // member variable for the RefLearnerActionTypeId property
        private Guid? _RefLearnerActionTypeId;

        // member variable for the Value property
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearnerActionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get => _AssessmentItemResponseId; set => SetProperty(ref _AssessmentItemResponseId, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionActorIdentifier { get => _LearnerActionActorIdentifier; set => SetProperty(ref _LearnerActionActorIdentifier, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.DateTime? LearnerActionDateTime { get => _LearnerActionDateTime; set => SetProperty(ref _LearnerActionDateTime, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectDescription { get => _LearnerActionObjectDescription; set => SetProperty(ref _LearnerActionObjectDescription, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get => _LearnerActionObjectIdentifier; set => SetProperty(ref _LearnerActionObjectIdentifier, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectType { get => _LearnerActionObjectType; set => SetProperty(ref _LearnerActionObjectType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get => _RefLearnerActionTypeId; set => SetProperty(ref _RefLearnerActionTypeId, value); }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerAction model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemResponseId = model.AssessmentItemResponseId;
            LearnerActionActorIdentifier = model.LearnerActionActorIdentifier;
            LearnerActionDateTime = model.LearnerActionDateTime;
            LearnerActionObjectDescription = model.LearnerActionObjectDescription;
            LearnerActionObjectIdentifier = model.LearnerActionObjectIdentifier;
            LearnerActionObjectType = model.LearnerActionObjectType;
            RefLearnerActionTypeId = model.RefLearnerActionTypeId;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
