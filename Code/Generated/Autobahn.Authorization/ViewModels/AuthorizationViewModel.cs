//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthorizationViewModel
     /// </summary>
    public partial class AuthorizationViewModel : ViewModelBase, Interfaces.IAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authorization";

        // member variable for the ApplicationRoleName property
        private System.String _ApplicationRoleName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthorizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The user role for which the person is allowed.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20129">Authorization Application Role Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Authorization Application Role Name")]
        public System.String ApplicationRoleName { get => _ApplicationRoleName; set => SetProperty(ref _ApplicationRoleName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationRoleName = model.ApplicationRoleName; // Authorization Application Role Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
