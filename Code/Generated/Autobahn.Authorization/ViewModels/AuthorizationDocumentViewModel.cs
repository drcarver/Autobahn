//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthorizationDocumentViewModel
     /// </summary>
    public partial class AuthorizationDocumentViewModel : ViewModelBase, Interfaces.IAuthorizationDocument
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AuthorizationDocument";

        // member variable for the AcceptanceIndicator property
        private System.Boolean? _AcceptanceIndicator;

        // member variable for the AuthorizationDate property
        private System.DateTime? _AuthorizationDate;

        // member variable for the DecisionExplanation property
        private System.String _DecisionExplanation;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAuthorizerTypeId property
        private Guid? _RefAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthorizationDocumentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.Boolean? AcceptanceIndicator { get => _AcceptanceIndicator; set => SetProperty(ref _AcceptanceIndicator, value); }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.DateTime? AuthorizationDate { get => _AuthorizationDate; set => SetProperty(ref _AuthorizationDate, value); }

        /// <summary>
        /// Type of person who authorized the decision or document.
        /// </summary>
        public System.String DecisionExplanation { get => _DecisionExplanation; set => SetProperty(ref _DecisionExplanation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAuthorizerType"/> model
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
            AcceptanceIndicator = model.AcceptanceIndicator;
            AuthorizationDate = model.AuthorizationDate;
            DecisionExplanation = model.DecisionExplanation;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAuthorizerTypeId = model.RefAuthorizerTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
