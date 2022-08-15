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
        /// The name of the company that provides the examination used in the teacher education program.
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
