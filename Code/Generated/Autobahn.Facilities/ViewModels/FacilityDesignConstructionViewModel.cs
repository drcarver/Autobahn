//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignConstructionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignConstructionViewModel
     /// </summary>
    public partial class FacilityDesignConstructionViewModel : ViewModelBase, Interfaces.IFacilityDesignConstructionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesignConstruction";

        // member variable for the FacilityDesignId property
        private Guid _FacilityDesignId;

        // member variable for the FacilityConstructionDate property
        private System.DateTime? _FacilityConstructionDate;

        // member variable for the FacilityConstructionYear property
        private System.String _FacilityConstructionYear;

        // member variable for the BuildingAdditionCode property
        private System.String _BuildingAdditionCode;

        // member variable for the BuildingAdditionDescription property
        private System.String _BuildingAdditionDescription;

        // member variable for the FacilityAdditionYear property
        private System.String _FacilityAdditionYear;

        // member variable for the BuildingSiteImprovementDescription property
        private System.String _BuildingSiteImprovementDescription;

        // member variable for the RefBuildingEnergyConservationMeasureTypeId property
        private Guid? _RefBuildingEnergyConservationMeasureTypeId;

        // member variable for the RefFacilityConstructionDateTypeId property
        private Guid? _RefFacilityConstructionDateTypeId;

        // member variable for the RefFacilityConstructionMaterialTypeId property
        private Guid? _RefFacilityConstructionMaterialTypeId;

        // member variable for the RefFacilityJointDevelopmentTypeId property
        private Guid? _RefFacilityJointDevelopmentTypeId;

        // member variable for the RefFacilitySiteImprovementLocationTypeId property
        private Guid? _RefFacilitySiteImprovementLocationTypeId;

        // member variable for the RefFacilityStandardTypeId property
        private Guid? _RefFacilityStandardTypeId;

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
        /// The title of the FacilityDesignConstructionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesignId"/> model
        /// </summary>
        public Guid FacilityDesignId { get => _FacilityDesignId; set => SetProperty(ref _FacilityDesignId, value); }

        public System.DateTime? FacilityConstructionDate { get => _FacilityConstructionDate; set => SetProperty(ref _FacilityConstructionDate, value); }

        public System.String FacilityConstructionYear  { get => _FacilityConstructionYear; set => SetProperty(ref _FacilityConstructionYear, value); }

        public System.String BuildingAdditionCode  { get => _BuildingAdditionCode; set => SetProperty(ref _BuildingAdditionCode, value); }

        public System.String BuildingAdditionDescription  { get => _BuildingAdditionDescription; set => SetProperty(ref _BuildingAdditionDescription, value); }

        public System.String FacilityAdditionYear  { get => _FacilityAdditionYear; set => SetProperty(ref _FacilityAdditionYear, value); }

        public System.String BuildingSiteImprovementDescription  { get => _BuildingSiteImprovementDescription; set => SetProperty(ref _BuildingSiteImprovementDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureTypeId"/> model
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get => _RefBuildingEnergyConservationMeasureTypeId; set => SetProperty(ref _RefBuildingEnergyConservationMeasureTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateTypeId"/> model
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get => _RefFacilityConstructionDateTypeId; set => SetProperty(ref _RefFacilityConstructionDateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialTypeId"/> model
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get => _RefFacilityConstructionMaterialTypeId; set => SetProperty(ref _RefFacilityConstructionMaterialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentTypeId"/> model
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get => _RefFacilityJointDevelopmentTypeId; set => SetProperty(ref _RefFacilityJointDevelopmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationTypeId"/> model
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get => _RefFacilitySiteImprovementLocationTypeId; set => SetProperty(ref _RefFacilitySiteImprovementLocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get => _RefFacilityStandardTypeId; set => SetProperty(ref _RefFacilityStandardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesignConstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityDesignId = model.FacilityDesignId;
            FacilityConstructionDate = model.FacilityConstructionDate;
            FacilityConstructionYear = model.FacilityConstructionYear;
            BuildingAdditionCode = model.BuildingAdditionCode;
            BuildingAdditionDescription = model.BuildingAdditionDescription;
            FacilityAdditionYear = model.FacilityAdditionYear;
            BuildingSiteImprovementDescription = model.BuildingSiteImprovementDescription;
            RefBuildingEnergyConservationMeasureTypeId = model.RefBuildingEnergyConservationMeasureTypeId;
            RefFacilityConstructionDateTypeId = model.RefFacilityConstructionDateTypeId;
            RefFacilityConstructionMaterialTypeId = model.RefFacilityConstructionMaterialTypeId;
            RefFacilityJointDevelopmentTypeId = model.RefFacilityJointDevelopmentTypeId;
            RefFacilitySiteImprovementLocationTypeId = model.RefFacilitySiteImprovementLocationTypeId;
            RefFacilityStandardTypeId = model.RefFacilityStandardTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
