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
        /// Supervised Clinical Experience Clock Hours
        /// <para>
        /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
        /// </para>
        /// </summary>
        Guid ProgramParticipationTeacherPrepId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationCredentialExam"/> model
        /// </summary>
        Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationExamScoreType"/> model
        /// </summary>
        Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationTestCompany"/> model
        /// </summary>
        Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
