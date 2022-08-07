//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionViewModel
     /// </summary>
    public partial class K12StudentCourseSectionViewModel : ViewModelBase, Interfaces.IK12StudentCourseSectionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSection";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the GradeEarned property
        private System.String _GradeEarned;

        // member variable for the GradeValueQualifier property
        private System.String _GradeValueQualifier;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the TuitionFunded property
        private System.Boolean? _TuitionFunded;

        // member variable for the ExitWithdrawalDate property
        private System.DateTime? _ExitWithdrawalDate;

        // member variable for the RefCourseRepeatCodeId property
        private Guid? _RefCourseRepeatCodeId;

        // member variable for the RefCourseSectionEnrollmentStatusTypeId property
        private Guid? _RefCourseSectionEnrollmentStatusTypeId;

        // member variable for the RefCourseSectionEntryTypeId property
        private Guid? _RefCourseSectionEntryTypeId;

        // member variable for the RefCourseSectionExitTypeId property
        private Guid? _RefCourseSectionExitTypeId;

        // member variable for the RefExitOrWithdrawalStatusId property
        private Guid? _RefExitOrWithdrawalStatusId;

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // member variable for the RefAdditionalCreditTypeId property
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefPreAndPostTestIndicatorId property
        private Guid? _RefPreAndPostTestIndicatorId;

        // member variable for the RefProgressLevelId property
        private Guid? _RefProgressLevelId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

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
        /// The title of the K12StudentCourseSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String GradeEarned  { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        public System.DateTime? ExitWithdrawalDate { get => _ExitWithdrawalDate; set => SetProperty(ref _ExitWithdrawalDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCodeId"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get => _RefCourseSectionEnrollmentStatusTypeId; set => SetProperty(ref _RefCourseSectionEnrollmentStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get => _RefCourseSectionEntryTypeId; set => SetProperty(ref _RefCourseSectionEntryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get => _RefCourseSectionExitTypeId; set => SetProperty(ref _RefCourseSectionExitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatusId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTakenId"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarnedId"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicatorId"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevelId"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            GradeEarned = model.GradeEarned;
            GradeValueQualifier = model.GradeValueQualifier;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            TuitionFunded = model.TuitionFunded;
            ExitWithdrawalDate = model.ExitWithdrawalDate;
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId;
            RefCourseSectionEnrollmentStatusTypeId = model.RefCourseSectionEnrollmentStatusTypeId;
            RefCourseSectionEntryTypeId = model.RefCourseSectionEntryTypeId;
            RefCourseSectionExitTypeId = model.RefCourseSectionExitTypeId;
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId;
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId;
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId;
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId;
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId;
            RefProgressLevelId = model.RefProgressLevelId;
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
