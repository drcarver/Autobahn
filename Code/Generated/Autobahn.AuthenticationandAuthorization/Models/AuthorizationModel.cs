//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthorizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The Authorization Model
     /// </summary>
    public partial class AuthorizationModel : AutobahnBase, Interfaces.IAuthorizationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Application"/> model
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Defines the Authorization.ApplicationRoleName non nullable property
        /// </summary>
        public System.String ApplicationRoleName { get; set; }

        /// <summary>
        /// Defines the Authorization.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Authorization.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
