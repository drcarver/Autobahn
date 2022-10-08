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
    [Table("ProgramParticipationTeacherPrep", Schema = "Common")]
    public partial class ProgramParticipationTeacherPrep
    {
        public ProgramParticipationTeacherPrep()
        {
            TeacherEducationCredentialExams = new HashSet<TeacherEducationCredentialExam>();
        }

        public int? RefTeacherPrepEnrollmentStatusId { get; set; }
        public int? RefTeacherPrepCompleterStatusId { get; set; }
        public int? RefSupervisedClinicalExperienceId { get; set; }
        public int? ClinicalExperienceClockHours { get; set; }
        public int? RefTeachingCredentialBasisId { get; set; }
        public int? RefTeachingCredentialTypeId { get; set; }
        public int? RefCriticalTeacherShortageCandidateId { get; set; }
        public int? RefAltRouteToCertificationOrLicensureId { get; set; }
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
        public int PersonProgramParticipationId { get; set; }
        [Key]
        public int ProgramParticipationTeacherPrepId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("SchoolAgeEducationPSCredits", TypeName = "decimal(10, 2)")]
        public decimal? SchoolAgeEducationPscredits { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAltRouteToCertificationOrLicensureId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefAltRouteToCertificationOrLicensure? RefAltRouteToCertificationOrLicensure { get; set; }
        [ForeignKey("RefCriticalTeacherShortageCandidateId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefCriticalTeacherShortageCandidate? RefCriticalTeacherShortageCandidate { get; set; }
        [ForeignKey("RefSupervisedClinicalExperienceId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefSupervisedClinicalExperience? RefSupervisedClinicalExperience { get; set; }
        [ForeignKey("RefTeacherPrepCompleterStatusId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefTeacherPrepCompleterStatus? RefTeacherPrepCompleterStatus { get; set; }
        [ForeignKey("RefTeacherPrepEnrollmentStatusId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefTeacherPrepEnrollmentStatus? RefTeacherPrepEnrollmentStatus { get; set; }
        [ForeignKey("RefTeachingCredentialBasisId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefTeachingCredentialBasis? RefTeachingCredentialBasis { get; set; }
        [ForeignKey("RefTeachingCredentialTypeId")]
        [InverseProperty("ProgramParticipationTeacherPreps")]
        public virtual RefTeachingCredentialType? RefTeachingCredentialType { get; set; }
        [InverseProperty("ProgramParticipationTeacherPrep")]
        public virtual ICollection<TeacherEducationCredentialExam> TeacherEducationCredentialExams { get; set; }
    }
}
