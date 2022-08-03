//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceUtilization.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpaceUtilization
     /// </summary>
    public partial class BuildingSpaceUtilization : IBuildingSpaceUtilization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSpace"/> model
        /// </summary>
        public Guid BuildingSpaceId { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.AvailableUtilizedInstructionalSpace nullable property
        /// </summary>
        public System.Boolean? AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingCapacityFactorIndicator nullable property
        /// </summary>
        public System.Boolean? BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingSpaceUtilizationArea nullable property
        /// </summary>
        public System.Decimal? BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.BuildingUnassignedSpaceIndicator nullable property
        /// </summary>
        public System.Boolean? BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorType"/> model
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSpaceUtilization.RecordEndDateTime nullable property
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
