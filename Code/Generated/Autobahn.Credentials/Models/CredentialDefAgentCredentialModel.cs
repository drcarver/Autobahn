//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgentCredential Model
     /// </summary>
    public partial class CredentialDefAgentCredentialModel : AutobahnBase, Interfaces.ICredentialDefAgentCredential
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CredentialDefAgentId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

    }
}
