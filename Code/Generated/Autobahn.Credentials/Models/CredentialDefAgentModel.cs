//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentModel.cs
//***************************************************************************

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
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        public Guid? RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
