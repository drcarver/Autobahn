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
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </summary>
        Guid? PersonId { get; set; }

        /// <summary>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </summary>
        Guid? RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
