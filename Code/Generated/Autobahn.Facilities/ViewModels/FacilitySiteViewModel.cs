//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySiteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySiteViewModel
     /// </summary>
    public partial class FacilitySiteViewModel : ViewModelBase, Interfaces.IFacilitySite
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySite";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilitySiteIdentifier property
        private System.String _FacilitySiteIdentifier;

        // member variable for the FacilitySiteArea property
        private System.Decimal? _FacilitySiteArea;

        // member variable for the RefBuildingSiteUseRestrictionsTypeId property
        private Guid? _RefBuildingSiteUseRestrictionsTypeId;

        // member variable for the RefFacilitySiteOutdoorAreaTypeId property
        private Guid? _RefFacilitySiteOutdoorAreaTypeId;

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
        /// The title of the FacilitySiteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.String FacilitySiteIdentifier  { get => _FacilitySiteIdentifier; set => SetProperty(ref _FacilitySiteIdentifier, value); }

        public System.Decimal? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get => _RefBuildingSiteUseRestrictionsTypeId; set => SetProperty(ref _RefBuildingSiteUseRestrictionsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaTypeId"/> model
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get => _RefFacilitySiteOutdoorAreaTypeId; set => SetProperty(ref _RefFacilitySiteOutdoorAreaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySite model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilitySiteIdentifier = model.FacilitySiteIdentifier;
            FacilitySiteArea = model.FacilitySiteArea;
            RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId;
            RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
