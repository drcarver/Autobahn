//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityUtilizationViewModel
     /// </summary>
    public partial class FacilityUtilizationViewModel : ViewModelBase, Interfaces.IFacilityUtilization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityUtilization";

        // member variable for the BuildingHoursOfPublicUsePerWeek property
        private System.Int32? _BuildingHoursOfPublicUsePerWeek;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityUtilizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20837">Building Hours of Public Use Per Week</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Hours of Public Use Per Week")]
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek; // Building Hours of Public Use Per Week
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
