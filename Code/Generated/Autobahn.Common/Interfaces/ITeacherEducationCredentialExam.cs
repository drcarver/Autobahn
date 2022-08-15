//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   ITeacherEducationCredentialExam.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherEducationCredentialExam Interface
     /// </summary>
    public partial interface ITeacherEducationCredentialExam : IAutobahnBase
    {
        /// <summary>
        /// The name of the company that provides the examination used in the teacher education program.
        /// </summary>
        Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
