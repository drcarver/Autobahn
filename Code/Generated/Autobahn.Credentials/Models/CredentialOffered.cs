//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialOffered.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialOffered
     /// </summary>
    public partial class CredentialOffered : ICredentialOffered
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.CredentialOfferedStartDate nullable property
        /// </summary>
        public System.DateTime? CredentialOfferedStartDate { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.CredentialOfferedEndDate nullable property
        /// </summary>
        public System.DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.RecordEndDateTime nullable property
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
