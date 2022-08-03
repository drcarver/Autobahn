//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentEnrollment.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentEnrollment
     /// </summary>
    public partial interface IPsStudentEnrollment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PSStudentEnrollment"/> model
        /// </summary>
        Guid PSStudentEnrollmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DegreeOrCertificateSeekingStudent nullable property
        /// </summary>
        System.Boolean? DegreeOrCertificateSeekingStudent { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.FirstTimePostsecondaryStudent nullable property
        /// </summary>
        System.Boolean? FirstTimePostsecondaryStudent { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InitialEnrollmentTerm non nullable property
        /// </summary>
        System.String InitialEnrollmentTerm { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InstructionalActivityHoursAttempted nullable property
        /// </summary>
        System.Decimal? InstructionalActivityHoursAttempted { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InstructionalActivityHoursCompleted nullable property
        /// </summary>
        System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.HousingOnCampus nullable property
        /// </summary>
        System.Boolean? HousingOnCampus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.FraternityParticipationStatus nullable property
        /// </summary>
        System.Boolean? FraternityParticipationStatus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.SororityParticipationStatus nullable property
        /// </summary>
        System.Boolean? SororityParticipationStatus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.EntryDateIntoPostsecondary nullable property
        /// </summary>
        System.DateTime? EntryDateIntoPostsecondary { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DistanceEducationProgramEnrollmentInd nullable property
        /// </summary>
        System.Boolean? DistanceEducationProgramEnrollmentInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralCandidacyAdmitInd nullable property
        /// </summary>
        System.Boolean? DoctoralCandidacyAdmitInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralCandidacyDate nullable property
        /// </summary>
        System.DateTime? DoctoralCandidacyDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralExamTakenDate nullable property
        /// </summary>
        System.DateTime? DoctoralExamTakenDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.OralDefenseCompletedIndicator nullable property
        /// </summary>
        System.Boolean? OralDefenseCompletedIndicator { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.OralDefenseDate nullable property
        /// </summary>
        System.DateTime? OralDefenseDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.PostsecondaryEnteringStudentInd nullable property
        /// </summary>
        System.Boolean? PostsecondaryEnteringStudentInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.ThesisOrDissertationTitle non nullable property
        /// </summary>
        System.String ThesisOrDissertationTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentType"/> model
        /// </summary>
        Guid? RefPsEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentStatus"/> model
        /// </summary>
        Guid? RefPsEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsStudentLevel"/> model
        /// </summary>
        Guid? RefPsStudentLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAwardType"/> model
        /// </summary>
        Guid? RefPsEnrollmentAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferReady"/> model
        /// </summary>
        Guid? RefTransferReadyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalActivityHours"/> model
        /// </summary>
        Guid? RefInstructionalActivityHoursId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDistanceEducationCourseEnrollment"/> model
        /// </summary>
        Guid? RefDistanceEducationCourseEnrollmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDoctoralExamsRequiredCode"/> model
        /// </summary>
        Guid? RefDoctoralExamsRequiredCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateOrDoctoralExamResultsStatus"/> model
        /// </summary>
        Guid? RefGraduateOrDoctoralExamResultsStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationReferralStatus"/> model
        /// </summary>
        Guid? RefDevelopmentalEducationReferralStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSExitOrWithdrawalType"/> model
        /// </summary>
        Guid? RefPSExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DisplacedStudentStatus nullable property
        /// </summary>
        System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
