//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the IdentityProviderName property
        private System.String _IdentityProviderName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthenticationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of a provider that can authenticate the identity of an person.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20122">Authentication Identity Provider Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider Name")]
        public System.String IdentityProviderName { get => _IdentityProviderName; set => SetProperty(ref _IdentityProviderName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            IdentityProviderName = model.IdentityProviderName; // Authentication Identity Provider Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
