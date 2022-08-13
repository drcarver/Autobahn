//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthenticationViewModel
     /// </summary>
    public partial class AuthenticationViewModel : ViewModelBase, Interfaces.IAuthentication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authentication";

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the IdentityProviderName property
        private System.String _IdentityProviderName;

        // member variable for the IdentityProviderUri property
        private System.String _IdentityProviderUri;

        // member variable for the LoginIdentifier property
        private System.String _LoginIdentifier;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthenticationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String IdentityProviderName { get => _IdentityProviderName; set => SetProperty(ref _IdentityProviderName, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String IdentityProviderUri { get => _IdentityProviderUri; set => SetProperty(ref _IdentityProviderUri, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.String LoginIdentifier { get => _LoginIdentifier; set => SetProperty(ref _LoginIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            EndDate = model.EndDate;
            IdentityProviderName = model.IdentityProviderName;
            IdentityProviderUri = model.IdentityProviderUri;
            LoginIdentifier = model.LoginIdentifier;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            StartDate = model.StartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
