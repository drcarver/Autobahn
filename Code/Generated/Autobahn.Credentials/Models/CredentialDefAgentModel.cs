//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgent Model
     /// </summary>
    public partial class CredentialDefAgentModel : AutobahnBase, Interfaces.ICredentialDefAgent
    {
        /// <summary>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
