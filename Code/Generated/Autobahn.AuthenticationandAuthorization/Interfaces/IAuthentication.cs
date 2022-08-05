//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   IAuthentication.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AuthenticationandAuthorization.Interfaces
{
     /// <summary>
     /// The IAuthentication
     /// </summary>
    public partial interface IAuthentication : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the Authentication.IdentityProviderName non nullable property
        /// </summary>
        System.String IdentityProviderName { get; set; }

        /// <summary>
        /// Defines the Authentication.IdentityProviderUri non nullable property
        /// </summary>
        System.String IdentityProviderUri { get; set; }

        /// <summary>
        /// Defines the Authentication.LoginIdentifier non nullable property
        /// </summary>
        System.String LoginIdentifier { get; set; }

        /// <summary>
        /// Defines the Authentication.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Authentication.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

    }
}
