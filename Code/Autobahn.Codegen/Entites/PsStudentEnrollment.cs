using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("PsStudentEnrollment", Schema = "Postsecondary")]
    public partial class PsStudentEnrollment
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PsStudentEnrollmentId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DegreeOrCertificateSeekingStudent { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FirstTimePostsecondaryStudent { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? InitialEnrollmentTerm { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InstructionalActivityHoursAttempted { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InstructionalActivityHoursCompleted { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? HousingOnCampus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FraternityParticipationStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? SororityParticipationStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EntryDateIntoPostsecondary { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DistanceEducationProgramEnrollmentInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DoctoralCandidacyAdmitInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DoctoralCandidacyDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DoctoralExamTakenDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? OralDefenseCompletedIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? OralDefenseDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? PostsecondaryEnteringStudentInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? ThesisOrDissertationTitle { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsEnrollmentTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsEnrollmentStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsStudentLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsEnrollmentAwardTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTransferReadyId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionalActivityHoursId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDistanceEducationCourseEnrollmentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDoctoralExamsRequiredCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGraduateOrDoctoralExamResultsStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDevelopmentalEducationReferralStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDevelopmentalEducationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPSExitOrWithdrawalTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DisplacedStudentStatus { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefDevelopmentalEducationReferralStatusId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefDevelopmentalEducationReferralStatus? RefDevelopmentalEducationReferralStatus { get; set; }
        [ForeignKey("RefDevelopmentalEducationTypeId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefDevelopmentalEducationType? RefDevelopmentalEducationType { get; set; }
        [ForeignKey("RefDistanceEducationCourseEnrollmentId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefDistanceEducationCourseEnrollment? RefDistanceEducationCourseEnrollment { get; set; }
        [ForeignKey("RefDoctoralExamsRequiredCodeId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefDoctoralExamsRequiredCode? RefDoctoralExamsRequiredCode { get; set; }
        [ForeignKey("RefGraduateOrDoctoralExamResultsStatusId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefGraduateOrDoctoralExamResultsStatus? RefGraduateOrDoctoralExamResultsStatus { get; set; }
        [ForeignKey("RefInstructionalActivityHoursId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefInstructionalActivityHour? RefInstructionalActivityHour { get; set; }
        [ForeignKey("RefPsEnrollmentAwardTypeId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefPsEnrollmentAwardType? RefPsEnrollmentAwardType { get; set; }
        [ForeignKey("RefPsEnrollmentStatusId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefPsEnrollmentStatus? RefPsEnrollmentStatus { get; set; }
        [ForeignKey("RefPsEnrollmentTypeId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefPsEnrollmentType? RefPsEnrollmentType { get; set; }
        [ForeignKey("RefPsStudentLevelId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefPsStudentLevel? RefPsStudentLevel { get; set; }
        [ForeignKey("RefPsexitOrWithdrawalTypeId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefPSExitOrWithdrawalType? RefPsexitOrWithdrawalType { get; set; }
        [ForeignKey("RefTransferReadyId")]
        [InverseProperty("PsStudentEnrollments")]
        public virtual RefTransferReady? RefTransferReady { get; set; }
    }
}
