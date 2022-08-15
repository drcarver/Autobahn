//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityLeaseViewModel
     /// </summary>
    public partial class FacilityLeaseViewModel : ViewModelBase, Interfaces.IFacilityLease
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityLease";

        // member variable for the FacilityLeaseAmount property
        private System.Decimal? _FacilityLeaseAmount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityLeaseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Lease Amount")]
        public System.Decimal? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityLease model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityLeaseAmount = model.FacilityLeaseAmount; // Facility Lease Amount
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
