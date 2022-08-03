//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialCriteriaCourse.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse
     /// </summary>
    public partial class CredentialCriteriaCourse : ICredentialCriteriaCourse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefCriteria"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Defines the CredentialCriteriaCourse.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialCriteriaCourse.RecordEndDateTime nullable property
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
