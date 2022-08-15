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
        System.String IdentityProviderName { get; set; }

    }
}
