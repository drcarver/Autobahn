//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ITeacherEducationCredentialExam.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherEducationCredentialExam
     /// </summary>
    public partial interface ITeacherEducationCredentialExam : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationCredentialExam"/> model
        /// </summary>
        Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationExamScoreType"/> model
        /// </summary>
        Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompany"/> model
        /// </summary>
        Guid? RefTeacherEducationTestCompanyId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTeacherPrep"/> model
        /// </summary>
        Guid ProgramParticipationTeacherPrepId { get; set; }

    }
}
