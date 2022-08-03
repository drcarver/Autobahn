//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSystemCategory.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemCategory
     /// </summary>
    public partial interface IBuildingSystemCategory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemType"/> model
        /// </summary>
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingElectricalSystemType"/> model
        /// </summary>
        Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFireProtectionSystemType"/> model
        /// </summary>
        Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHVACSystemType"/> model
        /// </summary>
        Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPlumbingSystemType"/> model
        /// </summary>
        Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSecuritySystemType"/> model
        /// </summary>
        Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSystemType"/> model
        /// </summary>
        Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSystemCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
