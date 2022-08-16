//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityViewModel
     /// </summary>
    public partial class FacilityViewModel : ViewModelBase, Interfaces.IFacility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Facility";

        // member variable for the BuildingArea property
        private  _BuildingArea;

        // member variable for the BuildingName property
        private  _BuildingName;

        // member variable for the BuildingNumberOfStories property
        private  _BuildingNumberOfStories;

        // member variable for the BuildingSiteNumber property
        private  _BuildingSiteNumber;

        // member variable for the BuildingYearBuilt property
        private  _BuildingYearBuilt;

        // member variable for the BuildingYearOfLastModernization property
        private  _BuildingYearOfLastModernization;

        // member variable for the FacilityAcquisitionDate property
        private  _FacilityAcquisitionDate;

        // member variable for the FacilityBuildingPermanency property
        private  _FacilityBuildingPermanency;

        // member variable for the FacilityExpectedLife property
        private  _FacilityExpectedLife;

        // member variable for the FacilityOwnershipIndicator property
        private  _FacilityOwnershipIndicator;

        // member variable for the Identifier property
        private Guid? _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingHistoricStatusId property
        private  _RefBuildingHistoricStatusId;

        // member variable for the RefBuildingPrimaryUseTypeId property
        private  _RefBuildingPrimaryUseTypeId;

        // member variable for the RefBuildingUseTypeId property
        private  _RefBuildingUseTypeId;

        // member variable for the RefCampusStatusId property
        private  _RefCampusStatusId;

        // member variable for the RefCampusTypeId property
        private  _RefCampusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BuildingArea { get => _BuildingArea; set => SetProperty(ref _BuildingArea, value); }

        /// <summary>
        /// </summary>
        public  BuildingName { get => _BuildingName; set => SetProperty(ref _BuildingName, value); }

        /// <summary>
        /// </summary>
        public  BuildingNumberOfStories { get => _BuildingNumberOfStories; set => SetProperty(ref _BuildingNumberOfStories, value); }

        /// <summary>
        /// </summary>
        public  BuildingSiteNumber { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// </summary>
        public  BuildingYearBuilt { get => _BuildingYearBuilt; set => SetProperty(ref _BuildingYearBuilt, value); }

        /// <summary>
        /// </summary>
        public  BuildingYearOfLastModernization { get => _BuildingYearOfLastModernization; set => SetProperty(ref _BuildingYearOfLastModernization, value); }

        /// <summary>
        /// </summary>
        public  FacilityAcquisitionDate { get => _FacilityAcquisitionDate; set => SetProperty(ref _FacilityAcquisitionDate, value); }

        /// <summary>
        /// </summary>
        public  FacilityBuildingPermanency { get => _FacilityBuildingPermanency; set => SetProperty(ref _FacilityBuildingPermanency, value); }

        /// <summary>
        /// </summary>
        public  FacilityExpectedLife { get => _FacilityExpectedLife; set => SetProperty(ref _FacilityExpectedLife, value); }

        /// <summary>
        /// </summary>
        public  FacilityOwnershipIndicator { get => _FacilityOwnershipIndicator; set => SetProperty(ref _FacilityOwnershipIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHistoricStatus"/> model
        /// </summary>
        public  RefBuildingHistoricStatusId { get => _RefBuildingHistoricStatusId; set => SetProperty(ref _RefBuildingHistoricStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPrimaryUseType"/> model
        /// </summary>
        public  RefBuildingPrimaryUseTypeId { get => _RefBuildingPrimaryUseTypeId; set => SetProperty(ref _RefBuildingPrimaryUseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingUseType"/> model
        /// </summary>
        public  RefBuildingUseTypeId { get => _RefBuildingUseTypeId; set => SetProperty(ref _RefBuildingUseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusStatus"/> model
        /// </summary>
        public  RefCampusStatusId { get => _RefCampusStatusId; set => SetProperty(ref _RefCampusStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusType"/> model
        /// </summary>
        public  RefCampusTypeId { get => _RefCampusTypeId; set => SetProperty(ref _RefCampusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacility model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingArea = model.BuildingArea; // 
            BuildingName = model.BuildingName; // 
            BuildingNumberOfStories = model.BuildingNumberOfStories; // 
            BuildingSiteNumber = model.BuildingSiteNumber; // 
            BuildingYearBuilt = model.BuildingYearBuilt; // 
            BuildingYearOfLastModernization = model.BuildingYearOfLastModernization; // 
            FacilityAcquisitionDate = model.FacilityAcquisitionDate; // 
            FacilityBuildingPermanency = model.FacilityBuildingPermanency; // 
            FacilityExpectedLife = model.FacilityExpectedLife; // 
            FacilityOwnershipIndicator = model.FacilityOwnershipIndicator; // 
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingHistoricStatusId = model.RefBuildingHistoricStatusId; // 
            RefBuildingPrimaryUseTypeId = model.RefBuildingPrimaryUseTypeId; // 
            RefBuildingUseTypeId = model.RefBuildingUseTypeId; // 
            RefCampusStatusId = model.RefCampusStatusId; // 
            RefCampusTypeId = model.RefCampusTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
