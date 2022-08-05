//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolStatusViewModel
     /// </summary>
    public partial class K12SchoolStatusViewModel : ViewModelBase, Interfaces.IK12SchoolStatus
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolStatus";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the ConsolidatedMepFundsStatus property
        private System.Boolean? _ConsolidatedMepFundsStatus;

        // member variable for the ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus property
        private System.String _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus;

        // member variable for the RefMagnetSpecialProgramId property
        private Guid? _RefMagnetSpecialProgramId;

        // member variable for the RefAlternativeSchoolFocusId property
        private Guid? _RefAlternativeSchoolFocusId;

        // member variable for the RefInternetAccessId property
        private Guid? _RefInternetAccessId;

        // member variable for the RefRestructuringActionId property
        private Guid? _RefRestructuringActionId;

        // member variable for the RefTitleISchoolStatusId property
        private Guid? _RefTitleISchoolStatusId;

        // member variable for the RefNSLPStatusId property
        private Guid? _RefNSLPStatusId;

        // member variable for the RefSchoolDangerousStatusId property
        private Guid? _RefSchoolDangerousStatusId;

        // member variable for the RefSchoolImprovementStatusId property
        private Guid? _RefSchoolImprovementStatusId;

        // member variable for the RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId property
        private Guid? _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId;

        // member variable for the RefComprehensiveAndTargetedSupportId property
        private Guid? _RefComprehensiveAndTargetedSupportId;

        // member variable for the RefComprehensiveSupportId property
        private Guid? _RefComprehensiveSupportId;

        // member variable for the RefTargetedSupportId property
        private Guid? _RefTargetedSupportId;

        // member variable for the RefNationalSchoolLunchProgramStatusId property
        private Guid? _RefNationalSchoolLunchProgramStatusId;

        // member variable for the RefVirtualSchoolStatusId property
        private Guid? _RefVirtualSchoolStatusId;

        // member variable for the RefBlendedLearningModelTypeId property
        private Guid? _RefBlendedLearningModelTypeId;

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
        /// The title of the K12SchoolStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        public System.Boolean? ConsolidatedMepFundsStatus { get => _ConsolidatedMepFundsStatus; set => SetProperty(ref _ConsolidatedMepFundsStatus, value); }

        public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus  { get => _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; set => SetProperty(ref _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgramId"/> model
        /// </summary>
        public Guid? RefMagnetSpecialProgramId { get => _RefMagnetSpecialProgramId; set => SetProperty(ref _RefMagnetSpecialProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocusId"/> model
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get => _RefAlternativeSchoolFocusId; set => SetProperty(ref _RefAlternativeSchoolFocusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessId"/> model
        /// </summary>
        public Guid? RefInternetAccessId { get => _RefInternetAccessId; set => SetProperty(ref _RefInternetAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringActionId"/> model
        /// </summary>
        public Guid? RefRestructuringActionId { get => _RefRestructuringActionId; set => SetProperty(ref _RefRestructuringActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatusId"/> model
        /// </summary>
        public Guid? RefTitleISchoolStatusId { get => _RefTitleISchoolStatusId; set => SetProperty(ref _RefTitleISchoolStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatusId"/> model
        /// </summary>
        public Guid? RefNSLPStatusId { get => _RefNSLPStatusId; set => SetProperty(ref _RefNSLPStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatusId"/> model
        /// </summary>
        public Guid? RefSchoolDangerousStatusId { get => _RefSchoolDangerousStatusId; set => SetProperty(ref _RefSchoolDangerousStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatusId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get => _RefSchoolImprovementStatusId; set => SetProperty(ref _RefSchoolImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId"/> model
        /// </summary>
        public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get => _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; set => SetProperty(ref _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupportId"/> model
        /// </summary>
        public Guid? RefComprehensiveAndTargetedSupportId { get => _RefComprehensiveAndTargetedSupportId; set => SetProperty(ref _RefComprehensiveAndTargetedSupportId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportId"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportId { get => _RefComprehensiveSupportId; set => SetProperty(ref _RefComprehensiveSupportId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportId"/> model
        /// </summary>
        public Guid? RefTargetedSupportId { get => _RefTargetedSupportId; set => SetProperty(ref _RefTargetedSupportId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatusId"/> model
        /// </summary>
        public Guid? RefNationalSchoolLunchProgramStatusId { get => _RefNationalSchoolLunchProgramStatusId; set => SetProperty(ref _RefNationalSchoolLunchProgramStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatusId"/> model
        /// </summary>
        public Guid? RefVirtualSchoolStatusId { get => _RefVirtualSchoolStatusId; set => SetProperty(ref _RefVirtualSchoolStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelTypeId"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            ConsolidatedMepFundsStatus = model.ConsolidatedMepFundsStatus;
            ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus = model.ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus;
            RefMagnetSpecialProgramId = model.RefMagnetSpecialProgramId;
            RefAlternativeSchoolFocusId = model.RefAlternativeSchoolFocusId;
            RefInternetAccessId = model.RefInternetAccessId;
            RefRestructuringActionId = model.RefRestructuringActionId;
            RefTitleISchoolStatusId = model.RefTitleISchoolStatusId;
            RefNSLPStatusId = model.RefNSLPStatusId;
            RefSchoolDangerousStatusId = model.RefSchoolDangerousStatusId;
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId;
            RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId = model.RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId;
            RefComprehensiveAndTargetedSupportId = model.RefComprehensiveAndTargetedSupportId;
            RefComprehensiveSupportId = model.RefComprehensiveSupportId;
            RefTargetedSupportId = model.RefTargetedSupportId;
            RefNationalSchoolLunchProgramStatusId = model.RefNationalSchoolLunchProgramStatusId;
            RefVirtualSchoolStatusId = model.RefVirtualSchoolStatusId;
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
