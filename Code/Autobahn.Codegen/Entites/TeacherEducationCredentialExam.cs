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
    [Table("TeacherEducationCredentialExam", Schema = "Common")]
    public partial class TeacherEducationCredentialExam
    {
        public int? RefTeacherEducationCredentialExamId { get; set; }
        public int? RefTeacherEducationExamScoreTypeId { get; set; }
        public int? RefTeacherEducationTestCompanyId { get; set; }
        public int ProgramParticipationTeacherPrepId { get; set; }
        [Key]
        public int TeacherEducationCredentialExamId { get; set; }
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
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ProgramParticipationTeacherPrepId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual ProgramParticipationTeacherPrep ProgramParticipationTeacherPrep { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTeacherEducationCredentialExamId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual RefTeacherEducationCredentialExam? RefTeacherEducationCredentialExam { get; set; }
        [ForeignKey("RefTeacherEducationExamScoreTypeId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual RefTeacherEducationExamScoreType? RefTeacherEducationExamScoreType { get; set; }
        [ForeignKey("RefTeacherEducationTestCompanyId")]
        [InverseProperty("TeacherEducationCredentialExams")]
        public virtual RefTeacherEducationTestCompany? RefTeacherEducationTestCompany { get; set; }
    }
}
