//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServiceProvidedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ServiceProvidedViewModel
     /// </summary>
    public partial class ServiceProvidedViewModel : ViewModelBase, Interfaces.IServiceProvided
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvided";

        // member variable for the RefServicesId property
        private Guid? _RefServicesId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

        // member variable for the ServicesReceivedId property
        private Guid _ServicesReceivedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServiceProvidedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServices"/> model
        /// </summary>
        public Guid? RefServicesId { get => _RefServicesId; set => SetProperty(ref _RefServicesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get => _ServicesReceivedId; set => SetProperty(ref _ServicesReceivedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvided model)
        {
            IsBusy = true;
            Id = model.Id;
            RefServicesId = model.RefServicesId;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            ServicesReceivedId = model.ServicesReceivedId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
