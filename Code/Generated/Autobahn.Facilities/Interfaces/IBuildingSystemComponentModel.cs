//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSystemComponentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponentModel Interface
     /// </summary>
    public partial interface IBuildingSystemComponentModel : IAutobahnBase
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

    }
}
