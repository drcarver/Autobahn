//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponent.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponent
     /// </summary>
    public partial class BuildingSystemComponent : IBuildingSystemComponent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.InstallationDate non nullable property
        /// </summary>
        public System.String InstallationDate { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.LifecycleCost nullable property
        /// </summary>
        public System.Decimal? LifecycleCost { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.ComponentOrFixtureUsefulLife nullable property
        /// </summary>
        public System.Int32? ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.BuildingInstitutionalEquipmentDescription non nullable property
        /// </summary>
        public System.String BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsType"/> model
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentCondition"/> model
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponent.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
