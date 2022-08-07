//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.ViewModels
{
     /// <summary>
     /// The AuthorizationViewModel
     /// </summary>
    public partial class AuthorizationViewModel : ViewModelBase, Interfaces.IAuthorizationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authorization";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ApplicationId property
        private Guid? _ApplicationId;

        // member variable for the ApplicationRoleName property
        private System.String _ApplicationRoleName;

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
        /// The title of the AuthorizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ApplicationId"/> model
        /// </summary>
        public Guid? ApplicationId { get => _ApplicationId; set => SetProperty(ref _ApplicationId, value); }

        public System.String ApplicationRoleName  { get => _ApplicationRoleName; set => SetProperty(ref _ApplicationRoleName, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ApplicationId = model.ApplicationId;
            ApplicationRoleName = model.ApplicationRoleName;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
