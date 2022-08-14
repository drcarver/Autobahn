//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.DateTime? _ExitWithdrawalDate;

        // member variable for the GradeEarned property
        private System.String _GradeEarned;

        // member variable for the GradeValueQualifier property
        private System.String _GradeValueQualifier;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAdditionalCreditTypeId property
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // member variable for the RefCourseRepeatCodeId property
        private Guid? _RefCourseRepeatCodeId;

        // member variable for the RefCourseSectionEnrollmentStatusTypeId property
        private Guid? _RefCourseSectionEnrollmentStatusTypeId;

        // member variable for the RefCourseSectionEntryTypeId property
        private Guid? _RefCourseSectionEntryTypeId;

        // member variable for the RefCourseSectionExitTypeId property
        private Guid? _RefCourseSectionExitTypeId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // member variable for the RefExitOrWithdrawalStatusId property
        private Guid? _RefExitOrWithdrawalStatusId;

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // member variable for the RefPreAndPostTestIndicatorId property
        private Guid? _RefPreAndPostTestIndicatorId;

        // member variable for the RefProgressLevelId property
        private Guid? _RefProgressLevelId;

        // member variable for the TuitionFunded property
        private System.Boolean? _TuitionFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentCourseSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.DateTime? ExitWithdrawalDate { get => _ExitWithdrawalDate; set => SetProperty(ref _ExitWithdrawalDate, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.String GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.String GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get => _RefCourseSectionEnrollmentStatusTypeId; set => SetProperty(ref _RefCourseSectionEnrollmentStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get => _RefCourseSectionEntryTypeId; set => SetProperty(ref _RefCourseSectionEntryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get => _RefCourseSectionExitTypeId; set => SetProperty(ref _RefCourseSectionExitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            ExitWithdrawalDate = model.ExitWithdrawalDate;
            GradeEarned = model.GradeEarned;
            GradeValueQualifier = model.GradeValueQualifier;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId;
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId;
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId;
            RefCourseSectionEnrollmentStatusTypeId = model.RefCourseSectionEnrollmentStatusTypeId;
            RefCourseSectionEntryTypeId = model.RefCourseSectionEntryTypeId;
            RefCourseSectionExitTypeId = model.RefCourseSectionExitTypeId;
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId;
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId;
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId;
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId;
            RefProgressLevelId = model.RefProgressLevelId;
            TuitionFunded = model.TuitionFunded;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
