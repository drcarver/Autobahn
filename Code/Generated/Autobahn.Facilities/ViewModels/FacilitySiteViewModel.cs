//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the FacilitySiteArea property
        private System.Decimal? _FacilitySiteArea;

        // member variable for the FacilitySiteIdentifier property
        private System.String _FacilitySiteIdentifier;

        // member variable for the RefBuildingSiteUseRestrictionsTypeId property
        private Guid? _RefBuildingSiteUseRestrictionsTypeId;

        // member variable for the RefFacilitySiteOutdoorAreaTypeId property
        private Guid? _RefFacilitySiteOutdoorAreaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilitySiteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        public System.Decimal? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        public System.String FacilitySiteIdentifier { get => _FacilitySiteIdentifier; set => SetProperty(ref _FacilitySiteIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsType"/> model
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get => _RefBuildingSiteUseRestrictionsTypeId; set => SetProperty(ref _RefBuildingSiteUseRestrictionsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaType"/> model
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
            FacilitySiteArea = model.FacilitySiteArea;
            FacilitySiteIdentifier = model.FacilitySiteIdentifier;
            RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId;
            RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
