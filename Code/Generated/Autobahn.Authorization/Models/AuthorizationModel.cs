//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Authorization Model
     /// </summary>
    public partial class AuthorizationModel : AutobahnBase, Interfaces.IAuthorization
    {
        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.String ApplicationRoleName { get; set; }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

    }
}
