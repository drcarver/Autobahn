//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEnrollmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentEnrollmentViewModel
     /// </summary>
    public partial class PsStudentEnrollmentViewModel : BindableBase, IPsStudentEnrollment
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DisplacedStudentStatus property
        private System.Boolean? _DisplacedStudentStatus;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PSStudentEnrollmentId"/> model
        /// </summary>
        public Guid PSStudentEnrollmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

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
        public Guid? RefPsEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsStudentLevelId"/> model
        /// </summary>
        public Guid? RefPsStudentLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAwardTypeId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferReadyId"/> model
        /// </summary>
        public Guid? RefTransferReadyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalActivityHoursId"/> model
        /// </summary>
        public Guid? RefInstructionalActivityHoursId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDistanceEducationCourseEnrollmentId"/> model
        /// </summary>
        public Guid? RefDistanceEducationCourseEnrollmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDoctoralExamsRequiredCodeId"/> model
        /// </summary>
        public Guid? RefDoctoralExamsRequiredCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateOrDoctoralExamResultsStatusId"/> model
        /// </summary>
        public Guid? RefGraduateOrDoctoralExamResultsStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationReferralStatusId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationReferralStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationTypeId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSExitOrWithdrawalTypeId"/> model
        /// </summary>
        public Guid? RefPSExitOrWithdrawalTypeId { get; set; }

        public System.Boolean? DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

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
        public void Load(IPsStudentEnrollment model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefPSExitOrWithdrawalTypeId = model.RefPSExitOrWithdrawalTypeId;
            DisplacedStudentStatus = model.DisplacedStudentStatus;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
