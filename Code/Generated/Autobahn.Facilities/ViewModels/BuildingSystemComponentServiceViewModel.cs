//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentService View Model
     /// </summary>
    public partial class BuildingSystemComponentServiceViewModel : ViewModelBase, Interfaces.IBuildingSystemComponentService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponentService";

        // member variable for the BuildingSystemComponentId property
        private Guid _BuildingSystemComponentId;

        // ComponentOrFixtureScheduledServicedDate -- (backing property for Component or Fixture Scheduled Serviced Date)
        private System.DateTime? _ComponentOrFixtureScheduledServicedDate;

        // ComponentOrFixtureServicedDate -- (backing property for Component or Fixture Serviced Date)
        private System.DateTime? _ComponentOrFixtureServicedDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// Component or Fixture Scheduled Serviced Date
        /// <para>
        /// The month, day, and year a major component, system, equipment, or fixture is scheduled to be serviced for preventive or routine maintenance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20881">Component or Fixture Scheduled Serviced Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get => _ComponentOrFixtureScheduledServicedDate; set => SetProperty(ref _ComponentOrFixtureScheduledServicedDate, value); }

        /// <summary>
        /// Component or Fixture Serviced Date
        /// <para>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20880">Component or Fixture Serviced Date</a>
        /// </para>
        /// </summary>
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
            BuildingSystemComponentId = model.BuildingSystemComponentId; // 
            ComponentOrFixtureScheduledServicedDate = model.ComponentOrFixtureScheduledServicedDate; // Component or Fixture Scheduled Serviced Date
            ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate; // Component or Fixture Serviced Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
