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
        /// 
        /// </summary>
         AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    }
}
