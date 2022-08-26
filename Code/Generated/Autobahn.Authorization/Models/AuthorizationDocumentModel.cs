//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentModel.cs
//***************************************************************************

using Autobahn.Interfaces.Authorization;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AuthorizationDocument Model
     /// </summary>
    public partial class AuthorizationDocumentModel : AutobahnBase, IAuthorizationDocument
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
        public Boolean? AcceptanceIndicator { get; set; }

        /// <summary>
        /// Authorization Date
        /// <para>
        /// The date the authorization occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20706">Authorization Date</a>
        /// </para>
        /// </summary>
        public DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Authorization Decision Explanation
        /// <para>
        /// Authorizer's explanation regarding the authorization decision.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20703">Authorization Decision Explanation</a>
        /// </para>
        /// </summary>
        public System.String DecisionExplanation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authorizer Type
        /// <para>
        /// Type of person who authorized the decision or document.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20701">Authorizer Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAuthorizerTypeId { get; set; }

    }
}
