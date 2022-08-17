//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The TeacherEducationCredentialExam Model
     /// </summary>
    public partial class TeacherEducationCredentialExamModel : AutobahnBase, Interfaces.ITeacherEducationCredentialExam
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
        public Guid ProgramParticipationTeacherPrepId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationCredentialExam"/> model
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationExamScoreType"/> model
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeacherEducationTestCompany"/> model
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

    }
}
