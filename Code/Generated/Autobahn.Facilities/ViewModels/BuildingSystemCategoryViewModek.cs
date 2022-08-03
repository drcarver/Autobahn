//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemCategoryViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemCategoryViewModel
     /// </summary>
    public partial class BuildingSystemCategoryViewModel : BindableBase, IBuildingSystemCategory
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponentId"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommMgmtComponentSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCoolingGenerationSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingElectricalSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFireProtectionSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHeatingGenerationSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHVACSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalConveyingSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPlumbingSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSecuritySystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingTechnologyWiringSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingVerticalTransportationSystemTypeId"/> model
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

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
        public void Load(IBuildingSystemCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingSystemComponentId = model.BuildingSystemComponentId;
            RefBuildingAirDistributionSystemTypeId = model.RefBuildingAirDistributionSystemTypeId;
            RefBuildingCommMgmtComponentSystemTypeId = model.RefBuildingCommMgmtComponentSystemTypeId;
            RefBuildingCoolingGenerationSystemTypeId = model.RefBuildingCoolingGenerationSystemTypeId;
            RefBuildingElectricalSystemTypeId = model.RefBuildingElectricalSystemTypeId;
            RefBuildingFireProtectionSystemTypeId = model.RefBuildingFireProtectionSystemTypeId;
            RefBuildingHeatingGenerationSystemTypeId = model.RefBuildingHeatingGenerationSystemTypeId;
            RefBuildingHVACSystemTypeId = model.RefBuildingHVACSystemTypeId;
            RefBuildingMechanicalConveyingSystemTypeId = model.RefBuildingMechanicalConveyingSystemTypeId;
            RefBuildingMechanicalSystemTypeId = model.RefBuildingMechanicalSystemTypeId;
            RefBuildingPlumbingSystemTypeId = model.RefBuildingPlumbingSystemTypeId;
            RefBuildingSecuritySystemTypeId = model.RefBuildingSecuritySystemTypeId;
            RefBuildingSystemTypeId = model.RefBuildingSystemTypeId;
            RefBuildingTechnologyWiringSystemTypeId = model.RefBuildingTechnologyWiringSystemTypeId;
            RefBuildingVerticalTransportationSystemTypeId = model.RefBuildingVerticalTransportationSystemTypeId;
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
