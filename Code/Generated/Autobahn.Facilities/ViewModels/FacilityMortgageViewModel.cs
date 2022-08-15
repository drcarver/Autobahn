//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageViewModel
     /// </summary>
    public partial class FacilityMortgageViewModel : ViewModelBase, Interfaces.IFacilityMortgage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgage";

        // member variable for the FacilityMortgageInterestAmount property
        private System.Decimal? _FacilityMortgageInterestAmount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMortgageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Mortgage Interest Amount")]
        public System.Decimal? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgage model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount; // Facility Mortgage Interest Amount
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
