using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("BuildingSpaceUtilization", Schema = "Facilities")]
    public partial class BuildingSpaceUtilization
    {
        [Key]
        public int BuildingSpaceUtilizationId { get; set; }
        public int BuildingSpaceId { get; set; }
        public bool? AvailableUtilizedInstructionalSpace { get; set; }
        public bool? BuildingCapacityFactorIndicator { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? BuildingSpaceUtilizationArea { get; set; }
        public bool? BuildingUnassignedSpaceIndicator { get; set; }
        public int? RefBuildingCommunityUseSpaceTypeId { get; set; }
        public int? RefBuildingInstructionalSpaceFactorTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("BuildingSpaceId")]
        [InverseProperty("BuildingSpaceUtilizations")]
        public virtual BuildingSpace BuildingSpace { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("BuildingSpaceUtilizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("BuildingSpaceUtilizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingCommunityUseSpaceTypeId")]
        [InverseProperty("BuildingSpaceUtilizations")]
        public virtual RefBuildingCommunityUseSpaceType? RefBuildingCommunityUseSpaceType { get; set; }
        [ForeignKey("RefBuildingInstructionalSpaceFactorTypeId")]
        [InverseProperty("BuildingSpaceUtilizations")]
        public virtual RefBuildingInstructionalSpaceFactorType? RefBuildingInstructionalSpaceFactorType { get; set; }
    }
}
