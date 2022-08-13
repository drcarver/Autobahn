//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinancialViewModel
     /// </summary>
    public partial class FacilityFinancialViewModel : ViewModelBase, Interfaces.IFacilityFinancial
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityFinancial";

        // member variable for the FacilityLeaseId property
        private Guid? _FacilityLeaseId;

        // member variable for the FacilityMortgageFeeId property
        private Guid? _FacilityMortgageFeeId;

        // member variable for the FacilityMortgageId property
        private Guid? _FacilityMortgageId;

        // member variable for the OrganizationFinancialId property
        private Guid _OrganizationFinancialId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityFinancialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityLease"/> model
        /// </summary>
        public Guid? FacilityLeaseId { get => _FacilityLeaseId; set => SetProperty(ref _FacilityLeaseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageFee"/> model
        /// </summary>
        public Guid? FacilityMortgageFeeId { get => _FacilityMortgageFeeId; set => SetProperty(ref _FacilityMortgageFeeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        public Guid? FacilityMortgageId { get => _FacilityMortgageId; set => SetProperty(ref _FacilityMortgageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get => _OrganizationFinancialId; set => SetProperty(ref _OrganizationFinancialId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityLeaseId = model.FacilityLeaseId;
            FacilityMortgageFeeId = model.FacilityMortgageFeeId;
            FacilityMortgageId = model.FacilityMortgageId;
            OrganizationFinancialId = model.OrganizationFinancialId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
