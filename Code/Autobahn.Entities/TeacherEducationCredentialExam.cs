using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("TeacherEducationCredentialExam")]
    public partial class TeacherEducationCredentialExam
    {
        public int? RefTeacherEducationCredentialExamId { get; set; }

        public int? RefTeacherEducationExamScoreTypeId { get; set; }

        public int? RefTeacherEducationTestCompanyId { get; set; }

        public int ProgramParticipationTeacherPrepId { get; set; }

        public int TeacherEducationCredentialExamId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ProgramParticipationTeacherPrep ProgramParticipationTeacherPrep { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTeacherEducationCredentialExam RefTeacherEducationCredentialExam { get; set; }

        public virtual RefTeacherEducationExamScoreType RefTeacherEducationExamScoreType { get; set; }

        public virtual RefTeacherEducationTestCompany RefTeacherEducationTestCompany { get; set; }
    }
}
