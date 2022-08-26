//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefAgentCredential.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialDefAgentCredential Interface
     /// </summary>
    public partial interface ICredentialDefAgentCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
        /// </summary>
        Guid CredentialDefAgentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

    }
}
