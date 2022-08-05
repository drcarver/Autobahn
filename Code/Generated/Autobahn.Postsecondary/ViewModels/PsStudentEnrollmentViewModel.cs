//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentEnrollmentViewModel
     /// </summary>
    public partial class PsStudentEnrollmentViewModel : ViewModelBase, Interfaces.IPsStudentEnrollment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentEnrollment";

        // member variable for the PSStudentEnrollmentId property
        private Guid _PSStudentEnrollmentId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the DegreeOrCertificateSeekingStudent property
        private System.Boolean? _DegreeOrCertificateSeekingStudent;

        // member variable for the FirstTimePostsecondaryStudent property
        private System.Boolean? _FirstTimePostsecondaryStudent;

        // member variable for the InitialEnrollmentTerm property
        private System.String _InitialEnrollmentTerm;

        // member variable for the InstructionalActivityHoursAttempted property
        private System.Decimal? _InstructionalActivityHoursAttempted;

        // member variable for the InstructionalActivityHoursCompleted property
        private System.Decimal? _InstructionalActivityHoursCompleted;

        // member variable for the HousingOnCampus property
        private System.Boolean? _HousingOnCampus;

        // member variable for the FraternityParticipationStatus property
        private System.Boolean? _FraternityParticipationStatus;

        // member variable for the SororityParticipationStatus property
        private System.Boolean? _SororityParticipationStatus;

        // member variable for the EntryDateIntoPostsecondary property
        private System.DateTime? _EntryDateIntoPostsecondary;

        // member variable for the DistanceEducationProgramEnrollmentInd property
        private System.Boolean? _DistanceEducationProgramEnrollmentInd;

        // member variable for the DoctoralCandidacyAdmitInd property
        private System.Boolean? _DoctoralCandidacyAdmitInd;

        // member variable for the DoctoralCandidacyDate property
        private System.DateTime? _DoctoralCandidacyDate;

        // member variable for the DoctoralExamTakenDate property
        private System.DateTime? _DoctoralExamTakenDate;

        // member variable for the OralDefenseCompletedIndicator property
        private System.Boolean? _OralDefenseCompletedIndicator;

        // member variable for the OralDefenseDate property
        private System.DateTime? _OralDefenseDate;

        // member variable for the PostsecondaryEnteringStudentInd property
        private System.Boolean? _PostsecondaryEnteringStudentInd;

        // member variable for the ThesisOrDissertationTitle property
        private System.String _ThesisOrDissertationTitle;

        // member variable for the RefPsEnrollmentTypeId property
        private Guid? _RefPsEnrollmentTypeId;

        // member variable for the RefPsEnrollmentStatusId property
        private Guid? _RefPsEnrollmentStatusId;

        // member variable for the RefPsStudentLevelId property
        private Guid? _RefPsStudentLevelId;

        // member variable for the RefPsEnrollmentAwardTypeId property
        private Guid? _RefPsEnrollmentAwardTypeId;

        // member variable for the RefTransferReadyId property
        private Guid? _RefTransferReadyId;

        // member variable for the RefInstructionalActivityHoursId property
        private Guid? _RefInstructionalActivityHoursId;

        // member variable for the RefDistanceEducationCourseEnrollmentId property
        private Guid? _RefDistanceEducationCourseEnrollmentId;

        // member variable for the RefDoctoralExamsRequiredCodeId property
        private Guid? _RefDoctoralExamsRequiredCodeId;

        // member variable for the RefGraduateOrDoctoralExamResultsStatusId property
        private Guid? _RefGraduateOrDoctoralExamResultsStatusId;

        // member variable for the RefDevelopmentalEducationReferralStatusId property
        private Guid? _RefDevelopmentalEducationReferralStatusId;

        // member variable for the RefDevelopmentalEducationTypeId property
        private Guid? _RefDevelopmentalEducationTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefPSExitOrWithdrawalTypeId property
        private Guid? _RefPSExitOrWithdrawalTypeId;

        // member variable for the DisplacedStudentStatus property
        private System.Boolean? _DisplacedStudentStatus;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentEnrollmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PSStudentEnrollmentId"/> model
        /// </summary>
        public Guid PSStudentEnrollmentId { get => _PSStudentEnrollmentId; set => SetProperty(ref _PSStudentEnrollmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean? DegreeOrCertificateSeekingStudent { get => _DegreeOrCertificateSeekingStudent; set => SetProperty(ref _DegreeOrCertificateSeekingStudent, value); }

        public System.Boolean? FirstTimePostsecondaryStudent { get => _FirstTimePostsecondaryStudent; set => SetProperty(ref _FirstTimePostsecondaryStudent, value); }

        public System.String InitialEnrollmentTerm  { get => _InitialEnrollmentTerm; set => SetProperty(ref _InitialEnrollmentTerm, value); }

        public System.Decimal? InstructionalActivityHoursAttempted { get => _InstructionalActivityHoursAttempted; set => SetProperty(ref _InstructionalActivityHoursAttempted, value); }

        public System.Decimal? InstructionalActivityHoursCompleted { get => _InstructionalActivityHoursCompleted; set => SetProperty(ref _InstructionalActivityHoursCompleted, value); }

        public System.Boolean? HousingOnCampus { get => _HousingOnCampus; set => SetProperty(ref _HousingOnCampus, value); }

        public System.Boolean? FraternityParticipationStatus { get => _FraternityParticipationStatus; set => SetProperty(ref _FraternityParticipationStatus, value); }

        public System.Boolean? SororityParticipationStatus { get => _SororityParticipationStatus; set => SetProperty(ref _SororityParticipationStatus, value); }

        public System.DateTime? EntryDateIntoPostsecondary { get => _EntryDateIntoPostsecondary; set => SetProperty(ref _EntryDateIntoPostsecondary, value); }

        public System.Boolean? DistanceEducationProgramEnrollmentInd { get => _DistanceEducationProgramEnrollmentInd; set => SetProperty(ref _DistanceEducationProgramEnrollmentInd, value); }

        public System.Boolean? DoctoralCandidacyAdmitInd { get => _DoctoralCandidacyAdmitInd; set => SetProperty(ref _DoctoralCandidacyAdmitInd, value); }

        public System.DateTime? DoctoralCandidacyDate { get => _DoctoralCandidacyDate; set => SetProperty(ref _DoctoralCandidacyDate, value); }

        public System.DateTime? DoctoralExamTakenDate { get => _DoctoralExamTakenDate; set => SetProperty(ref _DoctoralExamTakenDate, value); }

        public System.Boolean? OralDefenseCompletedIndicator { get => _OralDefenseCompletedIndicator; set => SetProperty(ref _OralDefenseCompletedIndicator, value); }

        public System.DateTime? OralDefenseDate { get => _OralDefenseDate; set => SetProperty(ref _OralDefenseDate, value); }

        public System.Boolean? PostsecondaryEnteringStudentInd { get => _PostsecondaryEnteringStudentInd; set => SetProperty(ref _PostsecondaryEnteringStudentInd, value); }

        public System.String ThesisOrDissertationTitle  { get => _ThesisOrDissertationTitle; set => SetProperty(ref _ThesisOrDissertationTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentTypeId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentTypeId { get => _RefPsEnrollmentTypeId; set => SetProperty(ref _RefPsEnrollmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentStatusId { get => _RefPsEnrollmentStatusId; set => SetProperty(ref _RefPsEnrollmentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsStudentLevelId"/> model
        /// </summary>
        public Guid? RefPsStudentLevelId { get => _RefPsStudentLevelId; set => SetProperty(ref _RefPsStudentLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAwardTypeId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentAwardTypeId { get => _RefPsEnrollmentAwardTypeId; set => SetProperty(ref _RefPsEnrollmentAwardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferReadyId"/> model
        /// </summary>
        public Guid? RefTransferReadyId { get => _RefTransferReadyId; set => SetProperty(ref _RefTransferReadyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalActivityHoursId"/> model
        /// </summary>
        public Guid? RefInstructionalActivityHoursId { get => _RefInstructionalActivityHoursId; set => SetProperty(ref _RefInstructionalActivityHoursId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDistanceEducationCourseEnrollmentId"/> model
        /// </summary>
        public Guid? RefDistanceEducationCourseEnrollmentId { get => _RefDistanceEducationCourseEnrollmentId; set => SetProperty(ref _RefDistanceEducationCourseEnrollmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDoctoralExamsRequiredCodeId"/> model
        /// </summary>
        public Guid? RefDoctoralExamsRequiredCodeId { get => _RefDoctoralExamsRequiredCodeId; set => SetProperty(ref _RefDoctoralExamsRequiredCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateOrDoctoralExamResultsStatusId"/> model
        /// </summary>
        public Guid? RefGraduateOrDoctoralExamResultsStatusId { get => _RefGraduateOrDoctoralExamResultsStatusId; set => SetProperty(ref _RefGraduateOrDoctoralExamResultsStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationReferralStatusId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationReferralStatusId { get => _RefDevelopmentalEducationReferralStatusId; set => SetProperty(ref _RefDevelopmentalEducationReferralStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationTypeId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get => _RefDevelopmentalEducationTypeId; set => SetProperty(ref _RefDevelopmentalEducationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSExitOrWithdrawalTypeId"/> model
        /// </summary>
        public Guid? RefPSExitOrWithdrawalTypeId { get => _RefPSExitOrWithdrawalTypeId; set => SetProperty(ref _RefPSExitOrWithdrawalTypeId, value); }

        public System.Boolean? DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            PSStudentEnrollmentId = model.PSStudentEnrollmentId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            DegreeOrCertificateSeekingStudent = model.DegreeOrCertificateSeekingStudent;
            FirstTimePostsecondaryStudent = model.FirstTimePostsecondaryStudent;
            InitialEnrollmentTerm = model.InitialEnrollmentTerm;
            InstructionalActivityHoursAttempted = model.InstructionalActivityHoursAttempted;
            InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted;
            HousingOnCampus = model.HousingOnCampus;
            FraternityParticipationStatus = model.FraternityParticipationStatus;
            SororityParticipationStatus = model.SororityParticipationStatus;
            EntryDateIntoPostsecondary = model.EntryDateIntoPostsecondary;
            DistanceEducationProgramEnrollmentInd = model.DistanceEducationProgramEnrollmentInd;
            DoctoralCandidacyAdmitInd = model.DoctoralCandidacyAdmitInd;
            DoctoralCandidacyDate = model.DoctoralCandidacyDate;
            DoctoralExamTakenDate = model.DoctoralExamTakenDate;
            OralDefenseCompletedIndicator = model.OralDefenseCompletedIndicator;
            OralDefenseDate = model.OralDefenseDate;
            PostsecondaryEnteringStudentInd = model.PostsecondaryEnteringStudentInd;
            ThesisOrDissertationTitle = model.ThesisOrDissertationTitle;
            RefPsEnrollmentTypeId = model.RefPsEnrollmentTypeId;
            RefPsEnrollmentStatusId = model.RefPsEnrollmentStatusId;
            RefPsStudentLevelId = model.RefPsStudentLevelId;
            RefPsEnrollmentAwardTypeId = model.RefPsEnrollmentAwardTypeId;
            RefTransferReadyId = model.RefTransferReadyId;
            RefInstructionalActivityHoursId = model.RefInstructionalActivityHoursId;
            RefDistanceEducationCourseEnrollmentId = model.RefDistanceEducationCourseEnrollmentId;
            RefDoctoralExamsRequiredCodeId = model.RefDoctoralExamsRequiredCodeId;
            RefGraduateOrDoctoralExamResultsStatusId = model.RefGraduateOrDoctoralExamResultsStatusId;
            RefDevelopmentalEducationReferralStatusId = model.RefDevelopmentalEducationReferralStatusId;
            RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId;
            RefPSExitOrWithdrawalTypeId = model.RefPSExitOrWithdrawalTypeId;
            DisplacedStudentStatus = model.DisplacedStudentStatus;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
