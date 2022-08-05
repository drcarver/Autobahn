//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgent.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgent
     /// </summary>
    public partial class CredentialDefAgent : AutobahnBase, Interfaces.ICredentialDefAgent
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        public Guid? RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
