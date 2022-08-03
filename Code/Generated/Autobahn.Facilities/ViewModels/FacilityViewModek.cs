//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityViewModel
     /// </summary>
    public partial class FacilityViewModel : BindableBase, IFacility
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the BuildingName property
        private System.String _BuildingName;

        // member variable for the BuildingSiteNumber property
        private System.String _BuildingSiteNumber;

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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String BuildingName  { get => _BuildingName; set => SetProperty(ref _BuildingName, value); }

        public System.String BuildingSiteNumber  { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingUseTypeId"/> model
        /// </summary>
        public Guid? RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

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
        public Guid? RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPrimaryUseTypeId"/> model
        /// </summary>
        public Guid? RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusStatusId"/> model
        /// </summary>
        public Guid? RefCampusStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusTypeId"/> model
        /// </summary>
        public Guid? RefCampusTypeId { get; set; }

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
        public void Load(IFacility model)
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
