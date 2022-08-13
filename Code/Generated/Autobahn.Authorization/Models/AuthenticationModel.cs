//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Authentication Model
     /// </summary>
    public partial class AuthenticationModel : AutobahnBase, Interfaces.IAuthentication
    {
        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String IdentityProviderName { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String IdentityProviderUri { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String LoginIdentifier { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

    }
}
