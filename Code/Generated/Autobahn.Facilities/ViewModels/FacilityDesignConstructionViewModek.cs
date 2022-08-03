//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignConstructionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignConstructionViewModel
     /// </summary>
    public partial class FacilityDesignConstructionViewModel : BindableBase, IFacilityDesignConstruction
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesignId"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        public System.DateTime? FacilityConstructionDate { get => _FacilityConstructionDate; set => SetProperty(ref _FacilityConstructionDate, value); }

        public System.String FacilityConstructionYear  { get => _FacilityConstructionYear; set => SetProperty(ref _FacilityConstructionYear, value); }

        public System.String BuildingAdditionCode  { get => _BuildingAdditionCode; set => SetProperty(ref _BuildingAdditionCode, value); }

        public System.String BuildingAdditionDescription  { get => _BuildingAdditionDescription; set => SetProperty(ref _BuildingAdditionDescription, value); }

        public System.String FacilityAdditionYear  { get => _FacilityAdditionYear; set => SetProperty(ref _FacilityAdditionYear, value); }

        public System.String BuildingSiteImprovementDescription  { get => _BuildingSiteImprovementDescription; set => SetProperty(ref _BuildingSiteImprovementDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureTypeId"/> model
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateTypeId"/> model
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialTypeId"/> model
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentTypeId"/> model
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationTypeId"/> model
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get; set; }

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
        public void Load(IFacilityDesignConstruction model)
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
