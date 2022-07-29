using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("BuildingSpaceUtilization")]
    public partial class BuildingSpaceUtilization
    {
        public int BuildingSpaceUtilizationId { get; set; }

        public int BuildingSpaceId { get; set; }

        public bool? AvailableUtilizedInstructionalSpace { get; set; }

        public bool? BuildingCapacityFactorIndicator { get; set; }

        public decimal? BuildingSpaceUtilizationArea { get; set; }

        public bool? BuildingUnassignedSpaceIndicator { get; set; }

        public int? RefBuildingCommunityUseSpaceTypeId { get; set; }

        public int? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual BuildingSpace BuildingSpace { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingCommunityUseSpaceType RefBuildingCommunityUseSpaceType { get; set; }

        public virtual RefBuildingInstructionalSpaceFactorType RefBuildingInstructionalSpaceFactorType { get; set; }
    }
}
