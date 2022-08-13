//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageFeeViewModel
     /// </summary>
    public partial class FacilityMortgageFeeViewModel : ViewModelBase, Interfaces.IFacilityMortgageFee
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgageFee";

        // member variable for the FacilityMortgageId property
        private Guid _FacilityMortgageId;

        // member variable for the RefFacilityFinancingFeeTypeId property
        private Guid _RefFacilityFinancingFeeTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMortgageFeeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get => _FacilityMortgageId; set => SetProperty(ref _FacilityMortgageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFinancingFeeType"/> model
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
            FacilityMortgageId = model.FacilityMortgageId;
            RefFacilityFinancingFeeTypeId = model.RefFacilityFinancingFeeTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
