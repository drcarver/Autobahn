//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityEnergyViewModel
     /// </summary>
    public partial class FacilityEnergyViewModel : ViewModelBase, Interfaces.IFacilityEnergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityEnergy";

        // member variable for the BuildingEnergyServiceCompanyName property
        private System.String _BuildingEnergyServiceCompanyName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityEnergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20850">Building Energy Service Company Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Energy Service Company Name")]
        public System.String BuildingEnergyServiceCompanyName { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityEnergy model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName; // Building Energy Service Company Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
