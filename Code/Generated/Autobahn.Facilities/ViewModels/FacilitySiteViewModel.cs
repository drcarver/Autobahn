//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySiteViewModel
     /// </summary>
    public partial class FacilitySiteViewModel : ViewModelBase, Interfaces.IFacilitySite
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySite";

        // member variable for the FacilitySiteArea property
        private System.Decimal? _FacilitySiteArea;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilitySiteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20754">Facility Site Area</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Site Area")]
        public System.Decimal? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySite model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilitySiteArea = model.FacilitySiteArea; // Facility Site Area
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
