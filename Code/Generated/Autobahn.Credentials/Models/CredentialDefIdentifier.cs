//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefIdentifier.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefIdentifier
     /// </summary>
    public partial class CredentialDefIdentifier : AutobahnBase, Interfaces.ICredentialDefIdentifier
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
