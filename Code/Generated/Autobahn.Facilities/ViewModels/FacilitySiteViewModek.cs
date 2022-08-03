//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySiteViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySiteViewModel
     /// </summary>
    public partial class FacilitySiteViewModel : BindableBase, IFacilitySite
    {
#region "Backing Fields"
        // member variable for the FacilitySiteIdentifier property
        private System.String _FacilitySiteIdentifier;

        // member variable for the FacilitySiteArea property
        private System.Decimal? _FacilitySiteArea;

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

        public System.String FacilitySiteIdentifier  { get => _FacilitySiteIdentifier; set => SetProperty(ref _FacilitySiteIdentifier, value); }

        public System.Decimal? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaTypeId"/> model
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

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
        public void Load(IFacilitySite model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilitySiteIdentifier = model.FacilitySiteIdentifier;
            FacilitySiteArea = model.FacilitySiteArea;
            RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId;
            RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId;
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
