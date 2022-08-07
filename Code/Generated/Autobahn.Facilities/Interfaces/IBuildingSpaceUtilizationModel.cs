//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSpaceUtilizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpaceUtilizationModel Interface
     /// </summary>
    public partial interface IBuildingSpaceUtilizationModel : IAutobahnBase
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

    }
}
