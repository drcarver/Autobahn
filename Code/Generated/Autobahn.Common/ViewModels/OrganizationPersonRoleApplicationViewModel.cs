//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleApplicationViewModel
     /// </summary>
    public partial class OrganizationPersonRoleApplicationViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleApplication";

        // member variable for the ApplicationDate property
        private System.DateTime _ApplicationDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationDate = model.ApplicationDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
