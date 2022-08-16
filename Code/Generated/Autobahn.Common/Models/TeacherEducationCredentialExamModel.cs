//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherEducationCredentialExam Model
     /// </summary>
    public partial class TeacherEducationCredentialExamModel : AutobahnBase, Interfaces.ITeacherEducationCredentialExam
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
