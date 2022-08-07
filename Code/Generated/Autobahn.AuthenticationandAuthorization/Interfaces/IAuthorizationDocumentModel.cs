//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   IAuthorizationDocumentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AuthenticationandAuthorization.Interfaces
{
     /// <summary>
     /// The IAuthorizationDocumentModel Interface
     /// </summary>
    public partial interface IAuthorizationDocumentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.AcceptanceIndicator nullable property
        /// </summary>
        System.Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.AuthorizationDate nullable property
        /// </summary>
        System.DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Defines the AuthorizationDocument.DecisionExplanation non nullable property
        /// </summary>
        System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAuthorizerType"/> model
        /// </summary>
        Guid? RefAuthorizerTypeId { get; set; }

    }
}
