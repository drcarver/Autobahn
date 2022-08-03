//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityLeaseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityLeaseViewModel
     /// </summary>
    public partial class FacilityLeaseViewModel : BindableBase, IFacilityLease
    {
#region "Backing Fields"
        // member variable for the FacilityLeaseAmount property
        private System.Decimal? _FacilityLeaseAmount;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        public System.Decimal? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategoryId"/> model
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseTypeId"/> model
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFacilityLease model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityLeaseAmount = model.FacilityLeaseAmount;
            RefFacilityLeaseAmountCategoryId = model.RefFacilityLeaseAmountCategoryId;
            RefFacilityLeaseTypeId = model.RefFacilityLeaseTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
