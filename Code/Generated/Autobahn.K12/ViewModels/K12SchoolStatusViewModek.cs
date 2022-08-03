//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolStatusViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolStatusViewModel
     /// </summary>
    public partial class K12SchoolStatusViewModel : BindableBase, IK12SchoolStatus
    {
#region "Backing Fields"
        // member variable for the ConsolidatedMepFundsStatus property
        private System.Boolean? _ConsolidatedMepFundsStatus;

        // member variable for the ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus property
        private System.String _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        public System.Boolean? ConsolidatedMepFundsStatus { get => _ConsolidatedMepFundsStatus; set => SetProperty(ref _ConsolidatedMepFundsStatus, value); }

        public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus  { get => _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; set => SetProperty(ref _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgramId"/> model
        /// </summary>
        public Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocusId"/> model
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessId"/> model
        /// </summary>
        public Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringActionId"/> model
        /// </summary>
        public Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatusId"/> model
        /// </summary>
        public Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatusId"/> model
        /// </summary>
        public Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatusId"/> model
        /// </summary>
        public Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatusId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId"/> model
        /// </summary>
        public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupportId"/> model
        /// </summary>
        public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportId"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportId"/> model
        /// </summary>
        public Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatusId"/> model
        /// </summary>
        public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatusId"/> model
        /// </summary>
        public Guid? RefVirtualSchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelTypeId"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get; set; }

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
        public void Load(IK12SchoolStatus model)
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
