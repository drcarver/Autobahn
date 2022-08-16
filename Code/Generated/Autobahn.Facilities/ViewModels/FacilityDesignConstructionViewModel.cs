//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignConstructionViewModel
     /// </summary>
    public partial class FacilityDesignConstructionViewModel : ViewModelBase, Interfaces.IFacilityDesignConstruction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesignConstruction";

        // member variable for the BuildingAdditionCode property
        private  _BuildingAdditionCode;

        // member variable for the BuildingAdditionDescription property
        private  _BuildingAdditionDescription;

        // member variable for the BuildingSiteImprovementDescription property
        private  _BuildingSiteImprovementDescription;

        // member variable for the FacilityAdditionYear property
        private Guid? _FacilityAdditionYear;

        // member variable for the FacilityConstructionDate property
        private  _FacilityConstructionDate;

        // member variable for the FacilityConstructionYear property
        private  _FacilityConstructionYear;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingEnergyConservationMeasureTypeId property
        private  _RefBuildingEnergyConservationMeasureTypeId;

        // member variable for the RefFacilityConstructionDateTypeId property
        private  _RefFacilityConstructionDateTypeId;

        // member variable for the RefFacilityConstructionMaterialTypeId property
        private  _RefFacilityConstructionMaterialTypeId;

        // member variable for the RefFacilityJointDevelopmentTypeId property
        private  _RefFacilityJointDevelopmentTypeId;

        // member variable for the RefFacilitySiteImprovementLocationTypeId property
        private  _RefFacilitySiteImprovementLocationTypeId;

        // member variable for the RefFacilityStandardTypeId property
        private  _RefFacilityStandardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BuildingAdditionCode { get => _BuildingAdditionCode; set => SetProperty(ref _BuildingAdditionCode, value); }

        /// <summary>
        /// </summary>
        public  BuildingAdditionDescription { get => _BuildingAdditionDescription; set => SetProperty(ref _BuildingAdditionDescription, value); }

        /// <summary>
        /// </summary>
        public  BuildingSiteImprovementDescription { get => _BuildingSiteImprovementDescription; set => SetProperty(ref _BuildingSiteImprovementDescription, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilityAdditionYear { get => _FacilityAdditionYear; set => SetProperty(ref _FacilityAdditionYear, value); }

        /// <summary>
        /// </summary>
        public  FacilityConstructionDate { get => _FacilityConstructionDate; set => SetProperty(ref _FacilityConstructionDate, value); }

        /// <summary>
        /// </summary>
        public  FacilityConstructionYear { get => _FacilityConstructionYear; set => SetProperty(ref _FacilityConstructionYear, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureType"/> model
        /// </summary>
        public  RefBuildingEnergyConservationMeasureTypeId { get => _RefBuildingEnergyConservationMeasureTypeId; set => SetProperty(ref _RefBuildingEnergyConservationMeasureTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateType"/> model
        /// </summary>
        public  RefFacilityConstructionDateTypeId { get => _RefFacilityConstructionDateTypeId; set => SetProperty(ref _RefFacilityConstructionDateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialType"/> model
        /// </summary>
        public  RefFacilityConstructionMaterialTypeId { get => _RefFacilityConstructionMaterialTypeId; set => SetProperty(ref _RefFacilityConstructionMaterialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentType"/> model
        /// </summary>
        public  RefFacilityJointDevelopmentTypeId { get => _RefFacilityJointDevelopmentTypeId; set => SetProperty(ref _RefFacilityJointDevelopmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationType"/> model
        /// </summary>
        public  RefFacilitySiteImprovementLocationTypeId { get => _RefFacilitySiteImprovementLocationTypeId; set => SetProperty(ref _RefFacilitySiteImprovementLocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardType"/> model
        /// </summary>
        public  RefFacilityStandardTypeId { get => _RefFacilityStandardTypeId; set => SetProperty(ref _RefFacilityStandardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesignConstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingAdditionCode = model.BuildingAdditionCode; // 
            BuildingAdditionDescription = model.BuildingAdditionDescription; // 
            BuildingSiteImprovementDescription = model.BuildingSiteImprovementDescription; // 
            FacilityAdditionYear = model.FacilityAdditionYear; // 
            FacilityConstructionDate = model.FacilityConstructionDate; // 
            FacilityConstructionYear = model.FacilityConstructionYear; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingEnergyConservationMeasureTypeId = model.RefBuildingEnergyConservationMeasureTypeId; // 
            RefFacilityConstructionDateTypeId = model.RefFacilityConstructionDateTypeId; // 
            RefFacilityConstructionMaterialTypeId = model.RefFacilityConstructionMaterialTypeId; // 
            RefFacilityJointDevelopmentTypeId = model.RefFacilityJointDevelopmentTypeId; // 
            RefFacilitySiteImprovementLocationTypeId = model.RefFacilitySiteImprovementLocationTypeId; // 
            RefFacilityStandardTypeId = model.RefFacilityStandardTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
