//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefIdentifier.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefIdentifier
     /// </summary>
    public partial class CredentialDefIdentifier : ICredentialDefIdentifier
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Defines the CredentialDefIdentifier.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        public Guid? RefCredentialIdentifierSystemId { get; set; }

        /// <summary>
        /// Defines the CredentialDefIdentifier.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefIdentifier.RecordEndDateTime nullable property
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
