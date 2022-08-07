//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthorizationDocumentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The AuthorizationDocument Model
     /// </summary>
    public partial class AuthorizationDocumentModel : AutobahnBase, Interfaces.IAuthorizationDocumentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.AcceptanceIndicator nullable property
        /// </summary>
        public System.Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.AuthorizationDate nullable property
        /// </summary>
        public System.DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.DecisionExplanation non nullable property
        /// </summary>
        public System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAuthorizerType"/> model
        /// </summary>
        public Guid? RefAuthorizerTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
