//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityLeaseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityLeaseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.Decimal? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategoryId"/> model
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get => _RefFacilityLeaseAmountCategoryId; set => SetProperty(ref _RefFacilityLeaseAmountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseTypeId"/> model
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
