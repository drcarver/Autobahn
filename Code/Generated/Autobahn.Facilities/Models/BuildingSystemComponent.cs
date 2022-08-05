//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponent.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponent
     /// </summary>
    public partial class BuildingSystemComponent : AutobahnBase, Interfaces.IBuildingSystemComponent
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
