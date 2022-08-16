//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the LearnerActionActorIdentifier property
        private  _LearnerActionActorIdentifier;

        // member variable for the LearnerActionDateTime property
        private  _LearnerActionDateTime;

        // member variable for the LearnerActionObjectDescription property
        private  _LearnerActionObjectDescription;

        // member variable for the LearnerActionObjectIdentifier property
        private  _LearnerActionObjectIdentifier;

        // member variable for the LearnerActionObjectType property
        private  _LearnerActionObjectType;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLearnerActionTypeId property
        private Guid? _RefLearnerActionTypeId;

        // member variable for the Value property
        private  _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  LearnerActionActorIdentifier { get => _LearnerActionActorIdentifier; set => SetProperty(ref _LearnerActionActorIdentifier, value); }

        /// <summary>
        /// </summary>
        public  LearnerActionDateTime { get => _LearnerActionDateTime; set => SetProperty(ref _LearnerActionDateTime, value); }

        /// <summary>
        /// </summary>
        public  LearnerActionObjectDescription { get => _LearnerActionObjectDescription; set => SetProperty(ref _LearnerActionObjectDescription, value); }

        /// <summary>
        /// </summary>
        public  LearnerActionObjectIdentifier { get => _LearnerActionObjectIdentifier; set => SetProperty(ref _LearnerActionObjectIdentifier, value); }

        /// <summary>
        /// </summary>
        public  LearnerActionObjectType { get => _LearnerActionObjectType; set => SetProperty(ref _LearnerActionObjectType, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get => _RefLearnerActionTypeId; set => SetProperty(ref _RefLearnerActionTypeId, value); }

        /// <summary>
        /// </summary>
        public  Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerAction model)
        {
            IsBusy = true;
            Id = model.Id;
            LearnerActionActorIdentifier = model.LearnerActionActorIdentifier; // 
            LearnerActionDateTime = model.LearnerActionDateTime; // 
            LearnerActionObjectDescription = model.LearnerActionObjectDescription; // 
            LearnerActionObjectIdentifier = model.LearnerActionObjectIdentifier; // 
            LearnerActionObjectType = model.LearnerActionObjectType; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLearnerActionTypeId = model.RefLearnerActionTypeId; // 
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
