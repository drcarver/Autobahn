//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActionViewModel
     /// </summary>
    public partial class LearnerActionViewModel : BindableBase, ILearnerAction
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponseId"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionTypeId"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.DateTime? LearnerActionDateTime { get => _LearnerActionDateTime; set => SetProperty(ref _LearnerActionDateTime, value); }

        public System.String LearnerActionActorIdentifier  { get => _LearnerActionActorIdentifier; set => SetProperty(ref _LearnerActionActorIdentifier, value); }

        public System.String LearnerActionObjectDescription  { get => _LearnerActionObjectDescription; set => SetProperty(ref _LearnerActionObjectDescription, value); }

        public System.String LearnerActionObjectIdentifier  { get => _LearnerActionObjectIdentifier; set => SetProperty(ref _LearnerActionObjectIdentifier, value); }

        public System.String LearnerActionObjectType  { get => _LearnerActionObjectType; set => SetProperty(ref _LearnerActionObjectType, value); }

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
        public void Load(ILearnerAction model)
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
