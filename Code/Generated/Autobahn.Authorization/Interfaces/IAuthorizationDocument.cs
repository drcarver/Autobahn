//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorizationDocument.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAuthorizationDocument Interface
     /// </summary>
    public partial interface IAuthorizationDocument : IAutobahnBase
    {
        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        System.Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        System.DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        Guid? RefAuthorizerTypeId { get; set; }

    }
}
