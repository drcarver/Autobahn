//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The TeacherEducationCredentialExam Model
     /// </summary>
    public partial class TeacherEducationCredentialExamModel : ITeacherEducationCredentialExam
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region ITeacherEducationCredentialExam
        /// <summary>
        /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> model
        /// </summary>
        public Guid ProgramParticipationTeacherPrepId { get; set; }

        /// <summary>
        /// Teacher Education Credential Exam Type
        /// <para>
        /// The type of examination used to assess teacher candidate's knowledge and skills.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
        /// </para>
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Teacher Education Credential Exam Score Type
        /// <para>
        /// An indication of the type of credential exam associated with a given exam score.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
        /// </para>
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Teacher Education Test Company
        /// <para>
        /// The name of the company that provides the examination used in the teacher education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
        /// </para>
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

        #endregion
    }
}
