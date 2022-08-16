//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAEViewModel
     /// </summary>
    public partial class ProgramParticipationAEViewModel : ViewModelBase, Interfaces.IProgramParticipationAE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAE";

        // member variable for the DisplacedHomemakerIndicator property
        private Guid? _DisplacedHomemakerIndicator;

        // member variable for the InstructionalActivityHoursCompleted property
        private  _InstructionalActivityHoursCompleted;

        // member variable for the OutOfWorkforceIndicator property
        private  _OutOfWorkforceIndicator;

        // member variable for the PostsecondaryTransitionDate property
        private  _PostsecondaryTransitionDate;

        // member variable for the ProxyContactHours property
        private  _ProxyContactHours;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdultEducationProgramExitReasonId property
        private  _RefAdultEducationProgramExitReasonId;

        // member variable for the RefAeFunctioningLevelAtIntakeId property
        private  _RefAeFunctioningLevelAtIntakeId;

        // member variable for the RefAeFunctioningLevelAtPosttestId property
        private  _RefAeFunctioningLevelAtPosttestId;

        // member variable for the RefAeInstructionalProgramTypeId property
        private  _RefAeInstructionalProgramTypeId;

        // member variable for the RefAePostsecondaryTransitionActionId property
        private  _RefAePostsecondaryTransitionActionId;

        // member variable for the RefAeSpecialProgramTypeId property
        private  _RefAeSpecialProgramTypeId;

        // member variable for the RefCorrectionalEducationFacilityTypeId property
        private  _RefCorrectionalEducationFacilityTypeId;

        // member variable for the RefGoalsForAttendingAdultEducationId property
        private  _RefGoalsForAttendingAdultEducationId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private  _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        /// <summary>
        /// </summary>
        public  InstructionalActivityHoursCompleted { get => _InstructionalActivityHoursCompleted; set => SetProperty(ref _InstructionalActivityHoursCompleted, value); }

        /// <summary>
        /// </summary>
        public  OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        /// <summary>
        /// </summary>
        public  PostsecondaryTransitionDate { get => _PostsecondaryTransitionDate; set => SetProperty(ref _PostsecondaryTransitionDate, value); }

        /// <summary>
        /// </summary>
        public  ProxyContactHours { get => _ProxyContactHours; set => SetProperty(ref _ProxyContactHours, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
        /// </summary>
        public  RefAdultEducationProgramExitReasonId { get => _RefAdultEducationProgramExitReasonId; set => SetProperty(ref _RefAdultEducationProgramExitReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        public  RefAeFunctioningLevelAtIntakeId { get => _RefAeFunctioningLevelAtIntakeId; set => SetProperty(ref _RefAeFunctioningLevelAtIntakeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        public  RefAeFunctioningLevelAtPosttestId { get => _RefAeFunctioningLevelAtPosttestId; set => SetProperty(ref _RefAeFunctioningLevelAtPosttestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
        /// </summary>
        public  RefAeInstructionalProgramTypeId { get => _RefAeInstructionalProgramTypeId; set => SetProperty(ref _RefAeInstructionalProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
        /// </summary>
        public  RefAePostsecondaryTransitionActionId { get => _RefAePostsecondaryTransitionActionId; set => SetProperty(ref _RefAePostsecondaryTransitionActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
        /// </summary>
        public  RefAeSpecialProgramTypeId { get => _RefAeSpecialProgramTypeId; set => SetProperty(ref _RefAeSpecialProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
        /// </summary>
        public  RefCorrectionalEducationFacilityTypeId { get => _RefCorrectionalEducationFacilityTypeId; set => SetProperty(ref _RefCorrectionalEducationFacilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        public  RefGoalsForAttendingAdultEducationId { get => _RefGoalsForAttendingAdultEducationId; set => SetProperty(ref _RefGoalsForAttendingAdultEducationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAE model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // 
            InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted; // 
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // 
            PostsecondaryTransitionDate = model.PostsecondaryTransitionDate; // 
            ProxyContactHours = model.ProxyContactHours; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdultEducationProgramExitReasonId = model.RefAdultEducationProgramExitReasonId; // 
            RefAeFunctioningLevelAtIntakeId = model.RefAeFunctioningLevelAtIntakeId; // 
            RefAeFunctioningLevelAtPosttestId = model.RefAeFunctioningLevelAtPosttestId; // 
            RefAeInstructionalProgramTypeId = model.RefAeInstructionalProgramTypeId; // 
            RefAePostsecondaryTransitionActionId = model.RefAePostsecondaryTransitionActionId; // 
            RefAeSpecialProgramTypeId = model.RefAeSpecialProgramTypeId; // 
            RefCorrectionalEducationFacilityTypeId = model.RefCorrectionalEducationFacilityTypeId; // 
            RefGoalsForAttendingAdultEducationId = model.RefGoalsForAttendingAdultEducationId; // 
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
