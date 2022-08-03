//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgentCredential.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgentCredential
     /// </summary>
    public partial class CredentialDefAgentCredential : ICredentialDefAgentCredential
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefAgent"/> model
        /// </summary>
        public Guid CredentialDefAgentId { get; set; }

        /// <summary>
        /// Defines the CredentialDefAgentCredential.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefAgentCredential.RecordEndDateTime nullable property
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
