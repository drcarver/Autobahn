//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Authorization;

namespace Autobahn.Education.Authorization.Models
{
     /// <summary>
     /// The AuthorizationDocument Model
     /// </summary>
    public partial class AuthorizationDocumentModel : IAuthorizationDocument
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IAuthorizationDocument
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

        #endregion
    }
}
