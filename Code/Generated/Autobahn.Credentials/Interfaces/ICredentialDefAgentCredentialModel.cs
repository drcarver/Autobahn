//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefAgentCredentialModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgentCredentialModel Interface
     /// </summary>
    public partial interface ICredentialDefAgentCredentialModel : IAutobahnBase
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
