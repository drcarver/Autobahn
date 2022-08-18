//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentViewModel.cs
//* Name:       Authorization Acceptance Indicator
//* Definition: Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
     /// </summary>
    public partial class AuthorizationDocumentViewModel : ViewModelBase, Interfaces.IAuthorizationDocument
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AuthorizationDocument";

        // AcceptanceIndicator -- (backing property for Authorization Acceptance Indicator)
        private System.Boolean? _AcceptanceIndicator;

        // AuthorizationDate -- (backing property for Authorization Date)
        private System.DateTime? _AuthorizationDate;

        // DecisionExplanation -- (backing property for Authorization Decision Explanation)
        private System.String _DecisionExplanation;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAuthorizerTypeId -- (backing property for Authorizer Type)
        private Guid? _RefAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Authorization Acceptance Indicator
        /// <para>
        /// Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20702">Authorization Acceptance Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AcceptanceIndicator { get => _AcceptanceIndicator; set => SetProperty(ref _AcceptanceIndicator, value); }

        /// <summary>
        /// Authorization Date
        /// <para>
        /// The date the authorization occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20706">Authorization Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? AuthorizationDate { get => _AuthorizationDate; set => SetProperty(ref _AuthorizationDate, value); }

        /// <summary>
        /// Authorization Decision Explanation
        /// <para>
        /// Authorizer's explanation regarding the authorization decision.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20703">Authorization Decision Explanation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DecisionExplanation { get => _DecisionExplanation; set => SetProperty(ref _DecisionExplanation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Authorizer Type
        /// <para>
        /// Type of person who authorized the decision or document.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20701">Authorizer Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAuthorizerTypeId { get => _RefAuthorizerTypeId; set => SetProperty(ref _RefAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorizationDocument model)
        {
            IsBusy = true;
            Id = model.Id;
            AcceptanceIndicator = model.AcceptanceIndicator; // Authorization Acceptance Indicator
            AuthorizationDate = model.AuthorizationDate; // Authorization Date
            DecisionExplanation = model.DecisionExplanation; // Authorization Decision Explanation
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAuthorizerTypeId = model.RefAuthorizerTypeId; // Authorizer Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
