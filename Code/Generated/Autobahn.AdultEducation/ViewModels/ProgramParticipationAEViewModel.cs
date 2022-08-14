//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.Boolean? _DisplacedHomemakerIndicator;

        // member variable for the InstructionalActivityHoursCompleted property
        private System.Decimal? _InstructionalActivityHoursCompleted;

        // member variable for the OutOfWorkforceIndicator property
        private System.Boolean? _OutOfWorkforceIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the PostsecondaryTransitionDate property
        private System.DateTime? _PostsecondaryTransitionDate;

        // member variable for the ProxyContactHours property
        private System.Decimal? _ProxyContactHours;

        // member variable for the RefAdultEducationProgramExitReasonId property
        private Guid? _RefAdultEducationProgramExitReasonId;

        // member variable for the RefAeFunctioningLevelAtIntakeId property
        private Guid? _RefAeFunctioningLevelAtIntakeId;

        // member variable for the RefAeFunctioningLevelAtPosttestId property
        private Guid? _RefAeFunctioningLevelAtPosttestId;

        // member variable for the RefAeInstructionalProgramTypeId property
        private Guid? _RefAeInstructionalProgramTypeId;

        // member variable for the RefAePostsecondaryTransitionActionId property
        private Guid? _RefAePostsecondaryTransitionActionId;

        // member variable for the RefAeSpecialProgramTypeId property
        private Guid? _RefAeSpecialProgramTypeId;

        // member variable for the RefCorrectionalEducationFacilityTypeId property
        private Guid? _RefCorrectionalEducationFacilityTypeId;

        // member variable for the RefGoalsForAttendingAdultEducationId property
        private Guid? _RefGoalsForAttendingAdultEducationId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationAEViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get => _InstructionalActivityHoursCompleted; set => SetProperty(ref _InstructionalActivityHoursCompleted, value); }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.DateTime? PostsecondaryTransitionDate { get => _PostsecondaryTransitionDate; set => SetProperty(ref _PostsecondaryTransitionDate, value); }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Decimal? ProxyContactHours { get => _ProxyContactHours; set => SetProperty(ref _ProxyContactHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get => _RefAdultEducationProgramExitReasonId; set => SetProperty(ref _RefAdultEducationProgramExitReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get => _RefAeFunctioningLevelAtIntakeId; set => SetProperty(ref _RefAeFunctioningLevelAtIntakeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get => _RefAeFunctioningLevelAtPosttestId; set => SetProperty(ref _RefAeFunctioningLevelAtPosttestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get => _RefAeInstructionalProgramTypeId; set => SetProperty(ref _RefAeInstructionalProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get => _RefAePostsecondaryTransitionActionId; set => SetProperty(ref _RefAePostsecondaryTransitionActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get => _RefAeSpecialProgramTypeId; set => SetProperty(ref _RefAeSpecialProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get => _RefCorrectionalEducationFacilityTypeId; set => SetProperty(ref _RefCorrectionalEducationFacilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get => _RefGoalsForAttendingAdultEducationId; set => SetProperty(ref _RefGoalsForAttendingAdultEducationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAE model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator;
            InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted;
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            PostsecondaryTransitionDate = model.PostsecondaryTransitionDate;
            ProxyContactHours = model.ProxyContactHours;
            RefAdultEducationProgramExitReasonId = model.RefAdultEducationProgramExitReasonId;
            RefAeFunctioningLevelAtIntakeId = model.RefAeFunctioningLevelAtIntakeId;
            RefAeFunctioningLevelAtPosttestId = model.RefAeFunctioningLevelAtPosttestId;
            RefAeInstructionalProgramTypeId = model.RefAeInstructionalProgramTypeId;
            RefAePostsecondaryTransitionActionId = model.RefAePostsecondaryTransitionActionId;
            RefAeSpecialProgramTypeId = model.RefAeSpecialProgramTypeId;
            RefCorrectionalEducationFacilityTypeId = model.RefCorrectionalEducationFacilityTypeId;
            RefGoalsForAttendingAdultEducationId = model.RefGoalsForAttendingAdultEducationId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
