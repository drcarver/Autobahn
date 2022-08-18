//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgage View Model
     /// </summary>
    public partial class FacilityMortgageViewModel : ViewModelBase, Interfaces.IFacilityMortgage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgage";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilityMortgageInterestAmount -- (backing property for Facility Mortgage Interest Amount)
        private System.Decimal? _FacilityMortgageInterestAmount;

        // FacilityTotalAssessedValue -- (backing property for Facility Total Assessed Value)
        private System.Decimal? _FacilityTotalAssessedValue;

        // RefFacilityMortgageInterestTypeId -- (backing property for Facility Mortgage Interest Type)
        private Guid? _RefFacilityMortgageInterestTypeId;

        // RefFacilityMortgageTypeId -- (backing property for Facility Mortgage Type)
        private Guid? _RefFacilityMortgageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Mortgage Interest Amount
        /// <para>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        /// <summary>
        /// Facility Total Assessed Value
        /// <para>
        /// The total assessed value of property that constitutes the basis for public borrowing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilityTotalAssessedValue { get => _FacilityTotalAssessedValue; set => SetProperty(ref _FacilityTotalAssessedValue, value); }

        /// <summary>
        /// Facility Mortgage Interest Type
        /// <para>
        /// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get => _RefFacilityMortgageInterestTypeId; set => SetProperty(ref _RefFacilityMortgageInterestTypeId, value); }

        /// <summary>
        /// Facility Mortgage Type
        /// <para>
        /// The status of a mortgage as it relates to priority of payment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
        /// </para>
        /// </summary>
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
            FacilityId = model.FacilityId; // 
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount; // Facility Mortgage Interest Amount
            FacilityTotalAssessedValue = model.FacilityTotalAssessedValue; // Facility Total Assessed Value
            RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId; // Facility Mortgage Interest Type
            RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId; // Facility Mortgage Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
