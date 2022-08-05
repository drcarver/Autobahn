//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEnrollment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentEnrollment
     /// </summary>
    public partial class PsStudentEnrollment : AutobahnBase, Interfaces.IPsStudentEnrollment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PSStudentEnrollment"/> model
        /// </summary>
        public Guid PSStudentEnrollmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DegreeOrCertificateSeekingStudent nullable property
        /// </summary>
        public System.Boolean? DegreeOrCertificateSeekingStudent { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.FirstTimePostsecondaryStudent nullable property
        /// </summary>
        public System.Boolean? FirstTimePostsecondaryStudent { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InitialEnrollmentTerm non nullable property
        /// </summary>
        public System.String InitialEnrollmentTerm { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InstructionalActivityHoursAttempted nullable property
        /// </summary>
        public System.Decimal? InstructionalActivityHoursAttempted { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.InstructionalActivityHoursCompleted nullable property
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.HousingOnCampus nullable property
        /// </summary>
        public System.Boolean? HousingOnCampus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.FraternityParticipationStatus nullable property
        /// </summary>
        public System.Boolean? FraternityParticipationStatus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.SororityParticipationStatus nullable property
        /// </summary>
        public System.Boolean? SororityParticipationStatus { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.EntryDateIntoPostsecondary nullable property
        /// </summary>
        public System.DateTime? EntryDateIntoPostsecondary { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DistanceEducationProgramEnrollmentInd nullable property
        /// </summary>
        public System.Boolean? DistanceEducationProgramEnrollmentInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralCandidacyAdmitInd nullable property
        /// </summary>
        public System.Boolean? DoctoralCandidacyAdmitInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralCandidacyDate nullable property
        /// </summary>
        public System.DateTime? DoctoralCandidacyDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DoctoralExamTakenDate nullable property
        /// </summary>
        public System.DateTime? DoctoralExamTakenDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.OralDefenseCompletedIndicator nullable property
        /// </summary>
        public System.Boolean? OralDefenseCompletedIndicator { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.OralDefenseDate nullable property
        /// </summary>
        public System.DateTime? OralDefenseDate { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.PostsecondaryEnteringStudentInd nullable property
        /// </summary>
        public System.Boolean? PostsecondaryEnteringStudentInd { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.ThesisOrDissertationTitle non nullable property
        /// </summary>
        public System.String ThesisOrDissertationTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentType"/> model
        /// </summary>
        public Guid? RefPsEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefPsEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsStudentLevel"/> model
        /// </summary>
        public Guid? RefPsStudentLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAwardType"/> model
        /// </summary>
        public Guid? RefPsEnrollmentAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferReady"/> model
        /// </summary>
        public Guid? RefTransferReadyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalActivityHours"/> model
        /// </summary>
        public Guid? RefInstructionalActivityHoursId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDistanceEducationCourseEnrollment"/> model
        /// </summary>
        public Guid? RefDistanceEducationCourseEnrollmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDoctoralExamsRequiredCode"/> model
        /// </summary>
        public Guid? RefDoctoralExamsRequiredCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateOrDoctoralExamResultsStatus"/> model
        /// </summary>
        public Guid? RefGraduateOrDoctoralExamResultsStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationReferralStatus"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationReferralStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSExitOrWithdrawalType"/> model
        /// </summary>
        public Guid? RefPSExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentEnrollment.DisplacedStudentStatus nullable property
        /// </summary>
        public System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
