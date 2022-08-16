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
        private Guid? _FacilityLeaseAmount;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityLeaseAmountCategoryId property
        private  _RefFacilityLeaseAmountCategoryId;

        // member variable for the RefFacilityLeaseTypeId property
        private  _RefFacilityLeaseTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategory"/> model
        /// </summary>
        public  RefFacilityLeaseAmountCategoryId { get => _RefFacilityLeaseAmountCategoryId; set => SetProperty(ref _RefFacilityLeaseAmountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseType"/> model
        /// </summary>
        public  RefFacilityLeaseTypeId { get => _RefFacilityLeaseTypeId; set => SetProperty(ref _RefFacilityLeaseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityLease model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityLeaseAmount = model.FacilityLeaseAmount; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityLeaseAmountCategoryId = model.RefFacilityLeaseAmountCategoryId; // 
            RefFacilityLeaseTypeId = model.RefFacilityLeaseTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
