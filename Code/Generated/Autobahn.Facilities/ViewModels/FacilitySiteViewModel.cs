//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the FacilitySiteArea property
        private Guid? _FacilitySiteArea;

        // member variable for the FacilitySiteIdentifier property
        private  _FacilitySiteIdentifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingSiteUseRestrictionsTypeId property
        private  _RefBuildingSiteUseRestrictionsTypeId;

        // member variable for the RefFacilitySiteOutdoorAreaTypeId property
        private  _RefFacilitySiteOutdoorAreaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        /// <summary>
        /// </summary>
        public  FacilitySiteIdentifier { get => _FacilitySiteIdentifier; set => SetProperty(ref _FacilitySiteIdentifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsType"/> model
        /// </summary>
        public  RefBuildingSiteUseRestrictionsTypeId { get => _RefBuildingSiteUseRestrictionsTypeId; set => SetProperty(ref _RefBuildingSiteUseRestrictionsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaType"/> model
        /// </summary>
        public  RefFacilitySiteOutdoorAreaTypeId { get => _RefFacilitySiteOutdoorAreaTypeId; set => SetProperty(ref _RefFacilitySiteOutdoorAreaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySite model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilitySiteArea = model.FacilitySiteArea; // 
            FacilitySiteIdentifier = model.FacilitySiteIdentifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId; // 
            RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
