//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherEducationCredentialExam.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTeacherEducationCredentialExam
     /// </summary>
    public partial class RefTeacherEducationCredentialExam : IRefTeacherEducationCredentialExam
    {
        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTeacherEducationCredentialExam.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
