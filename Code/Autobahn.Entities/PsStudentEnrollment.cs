using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentEnrollment")]
    public partial class PsStudentEnrollment
    {
        public int PSStudentEnrollmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? DegreeOrCertificateSeekingStudent { get; set; }

        public bool? FirstTimePostsecondaryStudent { get; set; }

        [StringLength(30)]
        public string InitialEnrollmentTerm { get; set; }

        public decimal? InstructionalActivityHoursAttempted { get; set; }

        public decimal? InstructionalActivityHoursCompleted { get; set; }

        public bool? HousingOnCampus { get; set; }

        public bool? FraternityParticipationStatus { get; set; }

        public bool? SororityParticipationStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EntryDateIntoPostsecondary { get; set; }

        public bool? DistanceEducationProgramEnrollmentInd { get; set; }

        public bool? DoctoralCandidacyAdmitInd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoctoralCandidacyDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoctoralExamTakenDate { get; set; }

        public bool? OralDefenseCompletedIndicator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OralDefenseDate { get; set; }

        public bool? PostsecondaryEnteringStudentInd { get; set; }

        [StringLength(300)]
        public string ThesisOrDissertationTitle { get; set; }

        public int? RefPsEnrollmentTypeId { get; set; }

        public int? RefPsEnrollmentStatusId { get; set; }

        public int? RefPsStudentLevelId { get; set; }

        public int? RefPsEnrollmentAwardTypeId { get; set; }

        public int? RefTransferReadyId { get; set; }

        public int? RefInstructionalActivityHoursId { get; set; }

        public int? RefDistanceEducationCourseEnrollmentId { get; set; }

        public int? RefDoctoralExamsRequiredCodeId { get; set; }

        public int? RefGraduateOrDoctoralExamResultsStatusId { get; set; }

        public int? RefDevelopmentalEducationReferralStatusId { get; set; }

        public int? RefDevelopmentalEducationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefPSExitOrWithdrawalTypeId { get; set; }

        public bool? DisplacedStudentStatus { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefDevelopmentalEducationReferralStatu RefDevelopmentalEducationReferralStatu { get; set; }

        public virtual RefDevelopmentalEducationType RefDevelopmentalEducationType { get; set; }

        public virtual RefDistanceEducationCourseEnrollment RefDistanceEducationCourseEnrollment { get; set; }

        public virtual RefDoctoralExamsRequiredCode RefDoctoralExamsRequiredCode { get; set; }

        public virtual RefGraduateOrDoctoralExamResultsStatu RefGraduateOrDoctoralExamResultsStatu { get; set; }

        public virtual RefInstructionalActivityHour RefInstructionalActivityHour { get; set; }

        public virtual RefPsEnrollmentAwardType RefPsEnrollmentAwardType { get; set; }

        public virtual RefPsEnrollmentStatu RefPsEnrollmentStatu { get; set; }

        public virtual RefPsEnrollmentType RefPsEnrollmentType { get; set; }

        public virtual RefPSExitOrWithdrawalType RefPSExitOrWithdrawalType { get; set; }

        public virtual RefPsStudentLevel RefPsStudentLevel { get; set; }

        public virtual RefTransferReady RefTransferReady { get; set; }
    }
}
