//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialModel.cs
//***************************************************************************

using Autobahn.Interfaces.Credentials;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgentCredential Model
     /// </summary>
    public partial class CredentialDefAgentCredentialModel : AutobahnBase, ICredentialDefAgentCredential
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
        /// </summary>
        public Guid CredentialDefAgentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

    }
}
