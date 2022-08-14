//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the ApplicationId property
        private Guid? _ApplicationId;

        // member variable for the ApplicationRoleName property
        private System.String _ApplicationRoleName;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthorizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Application"/> model
        /// </summary>
        public Guid? ApplicationId { get => _ApplicationId; set => SetProperty(ref _ApplicationId, value); }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.String ApplicationRoleName { get => _ApplicationRoleName; set => SetProperty(ref _ApplicationRoleName, value); }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationId = model.ApplicationId;
            ApplicationRoleName = model.ApplicationRoleName;
            EndDate = model.EndDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            StartDate = model.StartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
