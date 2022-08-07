//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   ProgramParticipationAEViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAEViewModel
     /// </summary>
    public partial class ProgramParticipationAEViewModel : ViewModelBase, Interfaces.IProgramParticipationAEViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAE";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefAeInstructionalProgramTypeId property
        private Guid? _RefAeInstructionalProgramTypeId;

        // member variable for the RefAePostsecondaryTransitionActionId property
        private Guid? _RefAePostsecondaryTransitionActionId;

        // member variable for the PostsecondaryTransitionDate property
        private System.DateTime? _PostsecondaryTransitionDate;

        // member variable for the RefAeSpecialProgramTypeId property
        private Guid? _RefAeSpecialProgramTypeId;

        // member variable for the RefAeFunctioningLevelAtIntakeId property
        private Guid? _RefAeFunctioningLevelAtIntakeId;

        // member variable for the RefAeFunctioningLevelAtPosttestId property
        private Guid? _RefAeFunctioningLevelAtPosttestId;

        // member variable for the RefGoalsForAttendingAdultEducationId property
        private Guid? _RefGoalsForAttendingAdultEducationId;

        // member variable for the DisplacedHomemakerIndicator property
        private System.Boolean? _DisplacedHomemakerIndicator;

        // member variable for the ProxyContactHours property
        private System.Decimal? _ProxyContactHours;

        // member variable for the InstructionalActivityHoursCompleted property
        private System.Decimal? _InstructionalActivityHoursCompleted;

        // member variable for the RefCorrectionalEducationFacilityTypeId property
        private Guid? _RefCorrectionalEducationFacilityTypeId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the OutOfWorkforceIndicator property
        private System.Boolean? _OutOfWorkforceIndicator;

        // member variable for the RefAdultEducationProgramExitReasonId property
        private Guid? _RefAdultEducationProgramExitReasonId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationAEViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramTypeId"/> model
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get => _RefAeInstructionalProgramTypeId; set => SetProperty(ref _RefAeInstructionalProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionActionId"/> model
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get => _RefAePostsecondaryTransitionActionId; set => SetProperty(ref _RefAePostsecondaryTransitionActionId, value); }

        public System.DateTime? PostsecondaryTransitionDate { get => _PostsecondaryTransitionDate; set => SetProperty(ref _PostsecondaryTransitionDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramTypeId"/> model
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get => _RefAeSpecialProgramTypeId; set => SetProperty(ref _RefAeSpecialProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntakeId"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get => _RefAeFunctioningLevelAtIntakeId; set => SetProperty(ref _RefAeFunctioningLevelAtIntakeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttestId"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get => _RefAeFunctioningLevelAtPosttestId; set => SetProperty(ref _RefAeFunctioningLevelAtPosttestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducationId"/> model
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get => _RefGoalsForAttendingAdultEducationId; set => SetProperty(ref _RefGoalsForAttendingAdultEducationId, value); }

        public System.Boolean? DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        public System.Decimal? ProxyContactHours { get => _ProxyContactHours; set => SetProperty(ref _ProxyContactHours, value); }

        public System.Decimal? InstructionalActivityHoursCompleted { get => _InstructionalActivityHoursCompleted; set => SetProperty(ref _InstructionalActivityHoursCompleted, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityTypeId"/> model
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get => _RefCorrectionalEducationFacilityTypeId; set => SetProperty(ref _RefCorrectionalEducationFacilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        public System.Boolean? OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReasonId"/> model
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get => _RefAdultEducationProgramExitReasonId; set => SetProperty(ref _RefAdultEducationProgramExitReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAE model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefAeInstructionalProgramTypeId = model.RefAeInstructionalProgramTypeId;
            RefAePostsecondaryTransitionActionId = model.RefAePostsecondaryTransitionActionId;
            PostsecondaryTransitionDate = model.PostsecondaryTransitionDate;
            RefAeSpecialProgramTypeId = model.RefAeSpecialProgramTypeId;
            RefAeFunctioningLevelAtIntakeId = model.RefAeFunctioningLevelAtIntakeId;
            RefAeFunctioningLevelAtPosttestId = model.RefAeFunctioningLevelAtPosttestId;
            RefGoalsForAttendingAdultEducationId = model.RefGoalsForAttendingAdultEducationId;
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator;
            ProxyContactHours = model.ProxyContactHours;
            InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted;
            RefCorrectionalEducationFacilityTypeId = model.RefCorrectionalEducationFacilityTypeId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator;
            RefAdultEducationProgramExitReasonId = model.RefAdultEducationProgramExitReasonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
