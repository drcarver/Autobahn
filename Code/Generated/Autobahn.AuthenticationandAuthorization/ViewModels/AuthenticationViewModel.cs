//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthenticationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.ViewModels
{
     /// <summary>
     /// The AuthenticationViewModel
     /// </summary>
    public partial class AuthenticationViewModel : ViewModelBase, Interfaces.IAuthenticationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authentication";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the IdentityProviderName property
        private System.String _IdentityProviderName;

        // member variable for the IdentityProviderUri property
        private System.String _IdentityProviderUri;

        // member variable for the LoginIdentifier property
        private System.String _LoginIdentifier;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AuthenticationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String IdentityProviderName  { get => _IdentityProviderName; set => SetProperty(ref _IdentityProviderName, value); }

        public System.String IdentityProviderUri  { get => _IdentityProviderUri; set => SetProperty(ref _IdentityProviderUri, value); }

        public System.String LoginIdentifier  { get => _LoginIdentifier; set => SetProperty(ref _LoginIdentifier, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            IdentityProviderName = model.IdentityProviderName;
            IdentityProviderUri = model.IdentityProviderUri;
            LoginIdentifier = model.LoginIdentifier;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
