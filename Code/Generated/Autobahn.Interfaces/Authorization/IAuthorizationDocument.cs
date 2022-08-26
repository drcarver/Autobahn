//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorizationDocument.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Authorization
{
     /// <summary>
     /// The IAuthorizationDocument Interface
     /// </summary>
    public partial interface IAuthorizationDocument : IAutobahnBase
    {
        /// <summary>
        /// Authorization Acceptance Indicator
        /// <para>
        /// Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20702">Authorization Acceptance Indicator</a>
        /// </para>
        /// </summary>
        Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Authorization Date
        /// <para>
        /// The date the authorization occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20706">Authorization Date</a>
        /// </para>
        /// </summary>
        DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Authorization Decision Explanation
        /// <para>
        /// Authorizer's explanation regarding the authorization decision.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20703">Authorization Decision Explanation</a>
        /// </para>
        /// </summary>
        System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authorizer Type
        /// <para>
        /// Type of person who authorized the decision or document.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20701">Authorizer Type</a>
        /// </para>
        /// </summary>
        Guid? RefAuthorizerTypeId { get; set; }

    }
}
