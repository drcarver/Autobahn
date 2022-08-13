//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityReplacementValue property
        private System.Decimal? _FacilityReplacementValue;

        // member variable for the IndebtednessAmountAllowed property
        private System.Decimal? _IndebtednessAmountAllowed;

        // member variable for the InsuranceDeductible property
        private System.Decimal? _InsuranceDeductible;

        // member variable for the PublicEducationMillRate property
        private System.Decimal? _PublicEducationMillRate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityFinanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? FacilityReplacementValue { get => _FacilityReplacementValue; set => SetProperty(ref _FacilityReplacementValue, value); }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? IndebtednessAmountAllowed { get => _IndebtednessAmountAllowed; set => SetProperty(ref _IndebtednessAmountAllowed, value); }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? InsuranceDeductible { get => _InsuranceDeductible; set => SetProperty(ref _InsuranceDeductible, value); }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? PublicEducationMillRate { get => _PublicEducationMillRate; set => SetProperty(ref _PublicEducationMillRate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityReplacementValue = model.FacilityReplacementValue;
            IndebtednessAmountAllowed = model.IndebtednessAmountAllowed;
            InsuranceDeductible = model.InsuranceDeductible;
            PublicEducationMillRate = model.PublicEducationMillRate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
