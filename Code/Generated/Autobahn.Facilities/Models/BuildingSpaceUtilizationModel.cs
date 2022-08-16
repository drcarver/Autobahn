//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpaceUtilization Model
     /// </summary>
    public partial class BuildingSpaceUtilizationModel : AutobahnBase, Interfaces.IBuildingSpaceUtilization
    {
        /// <summary>
        /// 
        /// </summary>
        public  AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    }
}
