//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityHazardViewModel
     /// </summary>
    public partial class FacilityHazardViewModel : ViewModelBase, Interfaces.IFacilityHazard
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityHazard";

        // member variable for the FacilityLocationOfHazardousMaterials property
        private System.String _FacilityLocationOfHazardousMaterials;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityHazardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20789">Facility Location of Hazardous Materials</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Location of Hazardous Materials")]
        public System.String FacilityLocationOfHazardousMaterials { get => _FacilityLocationOfHazardousMaterials; set => SetProperty(ref _FacilityLocationOfHazardousMaterials, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityHazard model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityLocationOfHazardousMaterials = model.FacilityLocationOfHazardousMaterials; // Facility Location of Hazardous Materials
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
