//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityViewModel
     /// </summary>
    public partial class FacilityViewModel : ViewModelBase, Interfaces.IFacilityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Facility";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the BuildingName property
        private System.String _BuildingName;

        // member variable for the BuildingSiteNumber property
        private System.String _BuildingSiteNumber;

        // member variable for the RefBuildingUseTypeId property
        private Guid? _RefBuildingUseTypeId;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the BuildingArea property
        private System.String _BuildingArea;

        // member variable for the BuildingNumberOfStories property
        private System.String _BuildingNumberOfStories;

        // member variable for the BuildingYearBuilt property
        private System.String _BuildingYearBuilt;

        // member variable for the BuildingYearOfLastModernization property
        private System.String _BuildingYearOfLastModernization;

        // member variable for the FacilityAcquisitionDate property
        private System.DateTime? _FacilityAcquisitionDate;

        // member variable for the FacilityBuildingPermanency property
        private System.String _FacilityBuildingPermanency;

        // member variable for the FacilityExpectedLife property
        private System.String _FacilityExpectedLife;

        // member variable for the FacilityOwnershipIndicator property
        private System.Boolean? _FacilityOwnershipIndicator;

        // member variable for the RefBuildingHistoricStatusId property
        private Guid? _RefBuildingHistoricStatusId;

        // member variable for the RefBuildingPrimaryUseTypeId property
        private Guid? _RefBuildingPrimaryUseTypeId;

        // member variable for the RefCampusStatusId property
        private Guid? _RefCampusStatusId;

        // member variable for the RefCampusTypeId property
        private Guid? _RefCampusTypeId;

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
        /// The title of the FacilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String BuildingName  { get => _BuildingName; set => SetProperty(ref _BuildingName, value); }

        public System.String BuildingSiteNumber  { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingUseTypeId"/> model
        /// </summary>
        public Guid? RefBuildingUseTypeId { get => _RefBuildingUseTypeId; set => SetProperty(ref _RefBuildingUseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String BuildingArea  { get => _BuildingArea; set => SetProperty(ref _BuildingArea, value); }

        public System.String BuildingNumberOfStories  { get => _BuildingNumberOfStories; set => SetProperty(ref _BuildingNumberOfStories, value); }

        public System.String BuildingYearBuilt  { get => _BuildingYearBuilt; set => SetProperty(ref _BuildingYearBuilt, value); }

        public System.String BuildingYearOfLastModernization  { get => _BuildingYearOfLastModernization; set => SetProperty(ref _BuildingYearOfLastModernization, value); }

        public System.DateTime? FacilityAcquisitionDate { get => _FacilityAcquisitionDate; set => SetProperty(ref _FacilityAcquisitionDate, value); }

        public System.String FacilityBuildingPermanency  { get => _FacilityBuildingPermanency; set => SetProperty(ref _FacilityBuildingPermanency, value); }

        public System.String FacilityExpectedLife  { get => _FacilityExpectedLife; set => SetProperty(ref _FacilityExpectedLife, value); }

        public System.Boolean? FacilityOwnershipIndicator { get => _FacilityOwnershipIndicator; set => SetProperty(ref _FacilityOwnershipIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHistoricStatusId"/> model
        /// </summary>
        public Guid? RefBuildingHistoricStatusId { get => _RefBuildingHistoricStatusId; set => SetProperty(ref _RefBuildingHistoricStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPrimaryUseTypeId"/> model
        /// </summary>
        public Guid? RefBuildingPrimaryUseTypeId { get => _RefBuildingPrimaryUseTypeId; set => SetProperty(ref _RefBuildingPrimaryUseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusStatusId"/> model
        /// </summary>
        public Guid? RefCampusStatusId { get => _RefCampusStatusId; set => SetProperty(ref _RefCampusStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusTypeId"/> model
        /// </summary>
        public Guid? RefCampusTypeId { get => _RefCampusTypeId; set => SetProperty(ref _RefCampusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacility model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            BuildingName = model.BuildingName;
            BuildingSiteNumber = model.BuildingSiteNumber;
            RefBuildingUseTypeId = model.RefBuildingUseTypeId;
            OrganizationId = model.OrganizationId;
            BuildingArea = model.BuildingArea;
            BuildingNumberOfStories = model.BuildingNumberOfStories;
            BuildingYearBuilt = model.BuildingYearBuilt;
            BuildingYearOfLastModernization = model.BuildingYearOfLastModernization;
            FacilityAcquisitionDate = model.FacilityAcquisitionDate;
            FacilityBuildingPermanency = model.FacilityBuildingPermanency;
            FacilityExpectedLife = model.FacilityExpectedLife;
            FacilityOwnershipIndicator = model.FacilityOwnershipIndicator;
            RefBuildingHistoricStatusId = model.RefBuildingHistoricStatusId;
            RefBuildingPrimaryUseTypeId = model.RefBuildingPrimaryUseTypeId;
            RefCampusStatusId = model.RefCampusStatusId;
            RefCampusTypeId = model.RefCampusTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
