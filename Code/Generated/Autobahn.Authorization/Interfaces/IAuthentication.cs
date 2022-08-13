//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthentication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAuthentication Interface
     /// </summary>
    public partial interface IAuthentication : IAutobahnBase
    {
        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        System.String IdentityProviderName { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        System.String IdentityProviderUri { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        System.String LoginIdentifier { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        System.DateTime? StartDate { get; set; }

    }
}
