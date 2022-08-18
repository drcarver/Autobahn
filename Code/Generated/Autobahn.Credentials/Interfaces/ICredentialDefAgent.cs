//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefAgent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgent Interface
     /// </summary>
    public partial interface ICredentialDefAgent : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid? PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        Guid? RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
