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
    [Table("BuildingSystemComponent", Schema = "Facilities")]
    public partial class BuildingSystemComponent
    {
        public BuildingSystemComponent()
        {
            BuildingSystemCategories = new HashSet<BuildingSystemCategory>();
            BuildingSystemComponentServices = new HashSet<BuildingSystemComponentService>();
            FacilityCompliances = new HashSet<FacilityCompliance>();
        }

        [Key]
        public int BuildingSystemComponentId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(30)]
        public string? Identifier { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(4)]
        public string? InstallationDate { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? LifecycleCost { get; set; }
        public int? ComponentOrFixtureUsefulLife { get; set; }
        [StringLength(80)]
        public string? BuildingInstitutionalEquipmentDescription { get; set; }
        public int? RefFacilityFurnishingsTypeId { get; set; }
        public int? RefFacilitySystemOrComponentConditionId { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("BuildingSystemComponents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("BuildingSystemComponents")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("BuildingSystemComponents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityFurnishingsTypeId")]
        [InverseProperty("BuildingSystemComponents")]
        public virtual RefFacilityFurnishingsType? RefFacilityFurnishingsType { get; set; }
        [ForeignKey("RefFacilitySystemOrComponentConditionId")]
        [InverseProperty("BuildingSystemComponents")]
        public virtual RefFacilitySystemOrComponentCondition? RefFacilitySystemOrComponentCondition { get; set; }
        [InverseProperty("BuildingSystemComponent")]
        public virtual ICollection<BuildingSystemCategory> BuildingSystemCategories { get; set; }
        [InverseProperty("BuildingSystemComponent")]
        public virtual ICollection<BuildingSystemComponentService> BuildingSystemComponentServices { get; set; }
        [InverseProperty("BuildingSystemComponent")]
        public virtual ICollection<FacilityCompliance> FacilityCompliances { get; set; }
    }
}
