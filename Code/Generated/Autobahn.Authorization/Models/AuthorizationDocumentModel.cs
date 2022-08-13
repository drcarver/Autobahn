//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AuthorizationDocument Model
     /// </summary>
    public partial class AuthorizationDocumentModel : AutobahnBase, Interfaces.IAuthorizationDocument
    {
        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public Guid? RefAuthorizerTypeId { get; set; }

    }
}
