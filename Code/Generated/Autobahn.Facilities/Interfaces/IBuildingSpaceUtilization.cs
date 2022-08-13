//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSpaceUtilization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpaceUtilization Interface
     /// </summary>
    public partial interface IBuildingSpaceUtilization : IAutobahnBase
    {
        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        System.Boolean? AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        System.Boolean? BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        Guid BuildingSpaceId { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        System.Decimal? BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        System.Boolean? BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    }
}
