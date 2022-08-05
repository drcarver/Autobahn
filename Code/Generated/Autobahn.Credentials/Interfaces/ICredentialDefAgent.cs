//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefAgent.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgent
     /// </summary>
    public partial interface ICredentialDefAgent : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        Guid? PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        Guid? RefCredentialDefAgentRoleTypeId { get; set; }

    }
}
