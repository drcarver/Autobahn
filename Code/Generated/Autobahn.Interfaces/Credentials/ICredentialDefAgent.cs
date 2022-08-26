//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefAgent.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
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
        /// Credential Definition Agent Role Type
        /// <para>
        /// The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20895">Credential Definition Agent Role Type</a>
        /// </para>
        /// </summary>
        Guid? RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
        /// </summary>
        Guid? RefCtdlorganizationTypeId { get; set; }

    }
}
