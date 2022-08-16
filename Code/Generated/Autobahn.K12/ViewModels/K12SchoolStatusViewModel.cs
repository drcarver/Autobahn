//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the ConsolidatedMepFundsStatus property
        private  _ConsolidatedMepFundsStatus;

        // member variable for the ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus property
        private  _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAlternativeSchoolFocusId property
        private Guid? _RefAlternativeSchoolFocusId;

        // member variable for the RefBlendedLearningModelTypeId property
        private  _RefBlendedLearningModelTypeId;

        // member variable for the RefInternetAccessId property
        private  _RefInternetAccessId;

        // member variable for the RefMagnetSpecialProgramId property
        private  _RefMagnetSpecialProgramId;

        // member variable for the RefNationalSchoolLunchProgramStatusId property
        private  _RefNationalSchoolLunchProgramStatusId;

        // member variable for the RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId property
        private  _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId;

        // member variable for the RefRestructuringActionId property
        private  _RefRestructuringActionId;

        // member variable for the RefTitleISchoolStatusId property
        private  _RefTitleISchoolStatusId;

        // member variable for the RefVirtualSchoolStatusId property
        private  _RefVirtualSchoolStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ConsolidatedMepFundsStatus { get => _ConsolidatedMepFundsStatus; set => SetProperty(ref _ConsolidatedMepFundsStatus, value); }

        /// <summary>
        /// </summary>
        public  ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get => _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; set => SetProperty(ref _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get => _RefAlternativeSchoolFocusId; set => SetProperty(ref _RefAlternativeSchoolFocusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        public  RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
        /// </summary>
        public  RefInternetAccessId { get => _RefInternetAccessId; set => SetProperty(ref _RefInternetAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
        /// </summary>
        public  RefMagnetSpecialProgramId { get => _RefMagnetSpecialProgramId; set => SetProperty(ref _RefMagnetSpecialProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        public  RefNationalSchoolLunchProgramStatusId { get => _RefNationalSchoolLunchProgramStatusId; set => SetProperty(ref _RefNationalSchoolLunchProgramStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        public  RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get => _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; set => SetProperty(ref _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
        /// </summary>
        public  RefRestructuringActionId { get => _RefRestructuringActionId; set => SetProperty(ref _RefRestructuringActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        public  RefTitleISchoolStatusId { get => _RefTitleISchoolStatusId; set => SetProperty(ref _RefTitleISchoolStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        public  RefVirtualSchoolStatusId { get => _RefVirtualSchoolStatusId; set => SetProperty(ref _RefVirtualSchoolStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsolidatedMepFundsStatus = model.ConsolidatedMepFundsStatus; // 
            ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus = model.ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAlternativeSchoolFocusId = model.RefAlternativeSchoolFocusId; // 
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // 
            RefInternetAccessId = model.RefInternetAccessId; // 
            RefMagnetSpecialProgramId = model.RefMagnetSpecialProgramId; // 
            RefNationalSchoolLunchProgramStatusId = model.RefNationalSchoolLunchProgramStatusId; // 
            RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId = model.RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; // 
            RefRestructuringActionId = model.RefRestructuringActionId; // 
            RefTitleISchoolStatusId = model.RefTitleISchoolStatusId; // 
            RefVirtualSchoolStatusId = model.RefVirtualSchoolStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
