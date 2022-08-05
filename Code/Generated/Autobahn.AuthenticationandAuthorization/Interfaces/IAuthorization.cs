//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   IAuthorization.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AuthenticationandAuthorization.Interfaces
{
     /// <summary>
     /// The IAuthorization
     /// </summary>
    public partial interface IAuthorization : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Application"/> model
        /// </summary>
        Guid? ApplicationId { get; set; }

        /// <summary>
        /// Defines the Authorization.ApplicationRoleName non nullable property
        /// </summary>
        System.String ApplicationRoleName { get; set; }

        /// <summary>
        /// Defines the Authorization.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Authorization.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

    }
}
