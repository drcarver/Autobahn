//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSpaceUtilization.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpaceUtilization
     /// </summary>
    public partial interface IBuildingSpaceUtilization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSpace"/> model
        /// </summary>
        Guid BuildingSpaceId { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.AvailableUtilizedInstructionalSpace nullable property
        /// </summary>
        System.Boolean? AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingCapacityFactorIndicator nullable property
        /// </summary>
        System.Boolean? BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingSpaceUtilizationArea nullable property
        /// </summary>
        System.Decimal? BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingUnassignedSpaceIndicator nullable property
        /// </summary>
        System.Boolean? BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorType"/> model
        /// </summary>
        Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.RecordEndDateTime nullable property
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
