//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServiceProviderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ServiceProviderViewModel
     /// </summary>
    public partial class ServiceProviderViewModel : ViewModelBase, Interfaces.IServiceProvider
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvider";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ServiceProvidedId property
        private Guid _ServiceProvidedId;

        // member variable for the ServiceStaffId property
        private Guid _ServiceStaffId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServiceProviderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ServiceProvided"/> model
        /// </summary>
        public Guid ServiceProvidedId { get => _ServiceProvidedId; set => SetProperty(ref _ServiceProvidedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ServiceStaff"/> model
        /// </summary>
        public Guid ServiceStaffId { get => _ServiceStaffId; set => SetProperty(ref _ServiceStaffId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvider model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ServiceProvidedId = model.ServiceProvidedId;
            ServiceStaffId = model.ServiceStaffId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
