//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionViewModel
     /// </summary>
    public partial class K12StudentCourseSectionViewModel : ViewModelBase, Interfaces.IK12StudentCourseSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSection";

        // member variable for the ExitWithdrawalDate property
        private  _ExitWithdrawalDate;

        // member variable for the GradeEarned property
        private  _GradeEarned;

        // member variable for the GradeValueQualifier property
        private  _GradeValueQualifier;

        // member variable for the NumberOfCreditsAttempted property
        private  _NumberOfCreditsAttempted;

        // member variable for the NumberOfCreditsEarned property
        private  _NumberOfCreditsEarned;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdditionalCreditTypeId property
        private  _RefAdditionalCreditTypeId;

        // member variable for the RefCourseGpaApplicabilityId property
        private Guid? _RefCourseGpaApplicabilityId;

        // member variable for the RefCourseRepeatCodeId property
        private  _RefCourseRepeatCodeId;

        // member variable for the RefCourseSectionEnrollmentStatusTypeId property
        private  _RefCourseSectionEnrollmentStatusTypeId;

        // member variable for the RefCourseSectionEntryTypeId property
        private  _RefCourseSectionEntryTypeId;

        // member variable for the RefCourseSectionExitTypeId property
        private  _RefCourseSectionExitTypeId;

        // member variable for the RefCreditTypeEarnedId property
        private  _RefCreditTypeEarnedId;

        // member variable for the RefExitOrWithdrawalStatusId property
        private  _RefExitOrWithdrawalStatusId;

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private  _RefGradeLevelWhenCourseTakenId;

        // member variable for the RefPreAndPostTestIndicatorId property
        private  _RefPreAndPostTestIndicatorId;

        // member variable for the RefProgressLevelId property
        private  _RefProgressLevelId;

        // member variable for the TuitionFunded property
        private  _TuitionFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ExitWithdrawalDate { get => _ExitWithdrawalDate; set => SetProperty(ref _ExitWithdrawalDate, value); }

        /// <summary>
        /// </summary>
        public  GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        /// <summary>
        /// </summary>
        public  GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public  RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGpaApplicability"/> model
        /// </summary>
        public Guid? RefCourseGpaApplicabilityId { get => _RefCourseGpaApplicabilityId; set => SetProperty(ref _RefCourseGpaApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public  RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
        /// </summary>
        public  RefCourseSectionEnrollmentStatusTypeId { get => _RefCourseSectionEnrollmentStatusTypeId; set => SetProperty(ref _RefCourseSectionEnrollmentStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
        /// </summary>
        public  RefCourseSectionEntryTypeId { get => _RefCourseSectionEntryTypeId; set => SetProperty(ref _RefCourseSectionEntryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
        /// </summary>
        public  RefCourseSectionExitTypeId { get => _RefCourseSectionExitTypeId; set => SetProperty(ref _RefCourseSectionExitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public  RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public  RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public  RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public  RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public  RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        /// <summary>
        /// </summary>
        public  TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            ExitWithdrawalDate = model.ExitWithdrawalDate; // 
            GradeEarned = model.GradeEarned; // 
            GradeValueQualifier = model.GradeValueQualifier; // 
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // 
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // 
            RefCourseGpaApplicabilityId = model.RefCourseGpaApplicabilityId; // 
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // 
            RefCourseSectionEnrollmentStatusTypeId = model.RefCourseSectionEnrollmentStatusTypeId; // 
            RefCourseSectionEntryTypeId = model.RefCourseSectionEntryTypeId; // 
            RefCourseSectionExitTypeId = model.RefCourseSectionExitTypeId; // 
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // 
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // 
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // 
            RefProgressLevelId = model.RefProgressLevelId; // 
            TuitionFunded = model.TuitionFunded; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
