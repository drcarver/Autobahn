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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
