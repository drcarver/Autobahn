//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionViewModel
     /// </summary>
    public partial class K12StudentCourseSectionViewModel : BindableBase, IK12StudentCourseSection
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String GradeEarned  { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        public System.DateTime? ExitWithdrawalDate { get => _ExitWithdrawalDate; set => SetProperty(ref _ExitWithdrawalDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCodeId"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitTypeId"/> model
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatusId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTakenId"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarnedId"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicatorId"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevelId"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

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
        public void Load(IK12StudentCourseSection model)
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
