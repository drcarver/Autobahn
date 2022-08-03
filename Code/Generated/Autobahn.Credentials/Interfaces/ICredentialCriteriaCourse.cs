//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialCriteriaCourse.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialCriteriaCourse
     /// </summary>
    public partial interface ICredentialCriteriaCourse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefCriteria"/> model
        /// </summary>
        Guid CredentialDefCriteriaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Defines the CredentialCriteriaCourse.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialCriteriaCourse.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
