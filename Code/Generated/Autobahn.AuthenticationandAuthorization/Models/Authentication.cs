//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   Authentication.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The Authentication
     /// </summary>
    public partial class Authentication : AutobahnBase, Interfaces.IAuthentication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the Authentication.IdentityProviderName non nullable property
        /// </summary>
        public System.String IdentityProviderName { get; set; }

        /// <summary>
        /// Defines the Authentication.IdentityProviderUri non nullable property
        /// </summary>
        public System.String IdentityProviderUri { get; set; }

        /// <summary>
        /// Defines the Authentication.LoginIdentifier non nullable property
        /// </summary>
        public System.String LoginIdentifier { get; set; }

        /// <summary>
        /// Defines the Authentication.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Authentication.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
