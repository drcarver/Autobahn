//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgentCredential.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgentCredential
     /// </summary>
    public partial class CredentialDefAgentCredential : AutobahnBase, Interfaces.ICredentialDefAgentCredential
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
