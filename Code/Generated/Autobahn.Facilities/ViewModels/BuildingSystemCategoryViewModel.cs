//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemCategoryViewModel
     /// </summary>
    public partial class BuildingSystemCategoryViewModel : ViewModelBase, Interfaces.IBuildingSystemCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemCategory";

        // member variable for the BuildingSystemComponentId property
        private Guid _BuildingSystemComponentId;

        // member variable for the RefBuildingAirDistributionSystemTypeId property
        private Guid? _RefBuildingAirDistributionSystemTypeId;

        // member variable for the RefBuildingCommMgmtComponentSystemTypeId property
        private Guid? _RefBuildingCommMgmtComponentSystemTypeId;

        // member variable for the RefBuildingCoolingGenerationSystemTypeId property
        private Guid? _RefBuildingCoolingGenerationSystemTypeId;

        // member variable for the RefBuildingElectricalSystemTypeId property
        private Guid? _RefBuildingElectricalSystemTypeId;

        // member variable for the RefBuildingFireProtectionSystemTypeId property
        private Guid? _RefBuildingFireProtectionSystemTypeId;

        // member variable for the RefBuildingHeatingGenerationSystemTypeId property
        private Guid? _RefBuildingHeatingGenerationSystemTypeId;

        // member variable for the RefBuildingHVACSystemTypeId property
        private Guid? _RefBuildingHVACSystemTypeId;

        // member variable for the RefBuildingMechanicalConveyingSystemTypeId property
        private Guid? _RefBuildingMechanicalConveyingSystemTypeId;

        // member variable for the RefBuildingMechanicalSystemTypeId property
        private Guid? _RefBuildingMechanicalSystemTypeId;

        // member variable for the RefBuildingPlumbingSystemTypeId property
        private Guid? _RefBuildingPlumbingSystemTypeId;

        // member variable for the RefBuildingSecuritySystemTypeId property
        private Guid? _RefBuildingSecuritySystemTypeId;

        // member variable for the RefBuildingSystemTypeId property
        private Guid? _RefBuildingSystemTypeId;

        // member variable for the RefBuildingTechnologyWiringSystemTypeId property
        private Guid? _RefBuildingTechnologyWiringSystemTypeId;

        // member variable for the RefBuildingVerticalTransportationSystemTypeId property
        private Guid? _RefBuildingVerticalTransportationSystemTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get => _RefBuildingAirDistributionSystemTypeId; set => SetProperty(ref _RefBuildingAirDistributionSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get => _RefBuildingCommMgmtComponentSystemTypeId; set => SetProperty(ref _RefBuildingCommMgmtComponentSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get => _RefBuildingCoolingGenerationSystemTypeId; set => SetProperty(ref _RefBuildingCoolingGenerationSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingElectricalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get => _RefBuildingElectricalSystemTypeId; set => SetProperty(ref _RefBuildingElectricalSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFireProtectionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get => _RefBuildingFireProtectionSystemTypeId; set => SetProperty(ref _RefBuildingFireProtectionSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get => _RefBuildingHeatingGenerationSystemTypeId; set => SetProperty(ref _RefBuildingHeatingGenerationSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHVACSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get => _RefBuildingHVACSystemTypeId; set => SetProperty(ref _RefBuildingHVACSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get => _RefBuildingMechanicalConveyingSystemTypeId; set => SetProperty(ref _RefBuildingMechanicalConveyingSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get => _RefBuildingMechanicalSystemTypeId; set => SetProperty(ref _RefBuildingMechanicalSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPlumbingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get => _RefBuildingPlumbingSystemTypeId; set => SetProperty(ref _RefBuildingPlumbingSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSecuritySystemType"/> model
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get => _RefBuildingSecuritySystemTypeId; set => SetProperty(ref _RefBuildingSecuritySystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get => _RefBuildingSystemTypeId; set => SetProperty(ref _RefBuildingSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get => _RefBuildingTechnologyWiringSystemTypeId; set => SetProperty(ref _RefBuildingTechnologyWiringSystemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get => _RefBuildingVerticalTransportationSystemTypeId; set => SetProperty(ref _RefBuildingVerticalTransportationSystemTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemCategory model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
