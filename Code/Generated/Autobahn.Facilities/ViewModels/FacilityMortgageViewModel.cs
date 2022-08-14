//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityMortgageInterestAmount property
        private System.Decimal? _FacilityMortgageInterestAmount;

        // member variable for the FacilityTotalAssessedValue property
        private System.Decimal? _FacilityTotalAssessedValue;

        // member variable for the RefFacilityMortgageInterestTypeId property
        private Guid? _RefFacilityMortgageInterestTypeId;

        // member variable for the RefFacilityMortgageTypeId property
        private Guid? _RefFacilityMortgageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMortgageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        public System.Decimal? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        public System.Decimal? FacilityTotalAssessedValue { get => _FacilityTotalAssessedValue; set => SetProperty(ref _FacilityTotalAssessedValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get => _RefFacilityMortgageInterestTypeId; set => SetProperty(ref _RefFacilityMortgageInterestTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get => _RefFacilityMortgageTypeId; set => SetProperty(ref _RefFacilityMortgageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgage model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount;
            FacilityTotalAssessedValue = model.FacilityTotalAssessedValue;
            RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId;
            RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
