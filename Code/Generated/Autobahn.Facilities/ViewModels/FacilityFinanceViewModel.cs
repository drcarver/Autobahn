//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinanceViewModel
     /// </summary>
    public partial class FacilityFinanceViewModel : ViewModelBase, Interfaces.IFacilityFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityFinance";

        // member variable for the FacilityReplacementValue property
        private System.Decimal? _FacilityReplacementValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityFinanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20765">Facility Replacement Value</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Replacement Value")]
        public System.Decimal? FacilityReplacementValue { get => _FacilityReplacementValue; set => SetProperty(ref _FacilityReplacementValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityReplacementValue = model.FacilityReplacementValue; // Facility Replacement Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
