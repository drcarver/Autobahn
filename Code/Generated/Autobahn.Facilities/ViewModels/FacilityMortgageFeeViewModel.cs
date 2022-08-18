//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageFee View Model
     /// </summary>
    public partial class FacilityMortgageFeeViewModel : ViewModelBase, Interfaces.IFacilityMortgageFee
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgageFee";

        // member variable for the FacilityMortgageId property
        private Guid _FacilityMortgageId;

        // RefFacilityFinancingFeeTypeId -- (backing property for Facility Financing Fee Type)
        private Guid _RefFacilityFinancingFeeTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get => _FacilityMortgageId; set => SetProperty(ref _FacilityMortgageId, value); }

        /// <summary>
        /// Facility Financing Fee Type
        /// <para>
        /// The type of fee that one must pay when getting a mortgage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get => _RefFacilityFinancingFeeTypeId; set => SetProperty(ref _RefFacilityFinancingFeeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgageFee model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityMortgageId = model.FacilityMortgageId; // 
            RefFacilityFinancingFeeTypeId = model.RefFacilityFinancingFeeTypeId; // Facility Financing Fee Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
