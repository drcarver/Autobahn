//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefAgentCredential.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgentCredential
     /// </summary>
    public partial interface ICredentialDefAgentCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefAgent"/> model
        /// </summary>
        Guid CredentialDefAgentId { get; set; }

    }
}
