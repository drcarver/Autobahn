//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSystemComponent.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponent
     /// </summary>
    public partial interface IBuildingSystemComponent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.InstallationDate non nullable property
        /// </summary>
        System.String InstallationDate { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.LifecycleCost nullable property
        /// </summary>
        System.Decimal? LifecycleCost { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.ComponentOrFixtureUsefulLife nullable property
        /// </summary>
        System.Int32? ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.BuildingInstitutionalEquipmentDescription non nullable property
        /// </summary>
        System.String BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsType"/> model
        /// </summary>
        Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentCondition"/> model
        /// </summary>
        Guid? RefFacilitySystemOrComponentConditionId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.RecordEndDateTime nullable property
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
