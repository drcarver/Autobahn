//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherEducationCredentialExam.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherEducationCredentialExam
     /// </summary>
    public partial class TeacherEducationCredentialExam : ITeacherEducationCredentialExam
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationCredentialExam"/> model
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationExamScoreType"/> model
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompany"/> model
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTeacherPrep"/> model
        /// </summary>
        public Guid ProgramParticipationTeacherPrepId { get; set; }

        /// <summary>
        /// Defines the TeacherEducationCredentialExam.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the TeacherEducationCredentialExam.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
