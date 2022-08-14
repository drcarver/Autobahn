//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentServiceViewModel
     /// </summary>
    public partial class BuildingSystemComponentServiceViewModel : ViewModelBase, Interfaces.IBuildingSystemComponentService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponentService";

        // member variable for the BuildingSystemComponentId property
        private Guid _BuildingSystemComponentId;

        // member variable for the ComponentOrFixtureScheduledServicedDate property
        private System.DateTime? _ComponentOrFixtureScheduledServicedDate;

        // member variable for the ComponentOrFixtureServicedDate property
        private System.DateTime? _ComponentOrFixtureServicedDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemComponentServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get => _ComponentOrFixtureScheduledServicedDate; set => SetProperty(ref _ComponentOrFixtureScheduledServicedDate, value); }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        public System.DateTime? ComponentOrFixtureServicedDate { get => _ComponentOrFixtureServicedDate; set => SetProperty(ref _ComponentOrFixtureServicedDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponentService model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingSystemComponentId = model.BuildingSystemComponentId;
            ComponentOrFixtureScheduledServicedDate = model.ComponentOrFixtureScheduledServicedDate;
            ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
