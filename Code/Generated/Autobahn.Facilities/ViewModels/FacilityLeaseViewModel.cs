//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityLeaseAmount property
        private System.Decimal? _FacilityLeaseAmount;

        // member variable for the RefFacilityLeaseAmountCategoryId property
        private Guid? _RefFacilityLeaseAmountCategoryId;

        // member variable for the RefFacilityLeaseTypeId property
        private Guid? _RefFacilityLeaseTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityLeaseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        public System.Decimal? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategory"/> model
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get => _RefFacilityLeaseAmountCategoryId; set => SetProperty(ref _RefFacilityLeaseAmountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseType"/> model
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get => _RefFacilityLeaseTypeId; set => SetProperty(ref _RefFacilityLeaseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityLease model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityLeaseAmount = model.FacilityLeaseAmount;
            RefFacilityLeaseAmountCategoryId = model.RefFacilityLeaseAmountCategoryId;
            RefFacilityLeaseTypeId = model.RefFacilityLeaseTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
