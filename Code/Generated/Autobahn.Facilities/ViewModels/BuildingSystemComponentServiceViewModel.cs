//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the ComponentOrFixtureServicedDate property
        private System.DateTime? _ComponentOrFixtureServicedDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemComponentServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20880">Component or Fixture Serviced Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Component or Fixture Serviced Date")]
        public System.DateTime? ComponentOrFixtureServicedDate { get => _ComponentOrFixtureServicedDate; set => SetProperty(ref _ComponentOrFixtureServicedDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponentService model)
        {
            IsBusy = true;
            Id = model.Id;
            ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate; // Component or Fixture Serviced Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
