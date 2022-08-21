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
    [Table("BuildingSystemCategory")]
    public partial class BuildingSystemCategory
    {
        [Key]
        public int BuildingSystemCategoryId { get; set; }
        public int BuildingSystemComponentId { get; set; }
        public int? RefBuildingAirDistributionSystemTypeId { get; set; }
        public int? RefBuildingCommMgmtComponentSystemTypeId { get; set; }
        public int? RefBuildingCoolingGenerationSystemTypeId { get; set; }
        public int? RefBuildingElectricalSystemTypeId { get; set; }
        public int? RefBuildingFireProtectionSystemTypeId { get; set; }
        public int? RefBuildingHeatingGenerationSystemTypeId { get; set; }
        [Column("RefBuildingHVACSystemTypeId")]
        public int? RefBuildingHvacsystemTypeId { get; set; }
        public int? RefBuildingMechanicalConveyingSystemTypeId { get; set; }
        public int? RefBuildingMechanicalSystemTypeId { get; set; }
        public int? RefBuildingPlumbingSystemTypeId { get; set; }
        public int? RefBuildingSecuritySystemTypeId { get; set; }
        public int? RefBuildingSystemTypeId { get; set; }
        public int? RefBuildingTechnologyWiringSystemTypeId { get; set; }
        public int? RefBuildingVerticalTransportationSystemTypeId { get; set; }
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

        [ForeignKey("BuildingSystemComponentId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual BuildingSystemComponent BuildingSystemComponent { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingAirDistributionSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingAirDistributionSystemType? RefBuildingAirDistributionSystemType { get; set; }
        [ForeignKey("RefBuildingCommMgmtComponentSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingCommMgmtComponentSystemType? RefBuildingCommMgmtComponentSystemType { get; set; }
        [ForeignKey("RefBuildingCoolingGenerationSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingCoolingGenerationSystemType? RefBuildingCoolingGenerationSystemType { get; set; }
        [ForeignKey("RefBuildingElectricalSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingElectricalSystemType? RefBuildingElectricalSystemType { get; set; }
        [ForeignKey("RefBuildingFireProtectionSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingFireProtectionSystemType? RefBuildingFireProtectionSystemType { get; set; }
        [ForeignKey("RefBuildingHeatingGenerationSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingHeatingGenerationSystemType? RefBuildingHeatingGenerationSystemType { get; set; }
        [ForeignKey("RefBuildingHvacsystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingHvacsystemType? RefBuildingHvacsystemType { get; set; }
        [ForeignKey("RefBuildingMechanicalConveyingSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingMechanicalConveyingSystemType? RefBuildingMechanicalConveyingSystemType { get; set; }
        [ForeignKey("RefBuildingMechanicalSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingMechanicalSystemType? RefBuildingMechanicalSystemType { get; set; }
        [ForeignKey("RefBuildingPlumbingSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingPlumbingSystemType? RefBuildingPlumbingSystemType { get; set; }
        [ForeignKey("RefBuildingSecuritySystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingSecuritySystemType? RefBuildingSecuritySystemType { get; set; }
        [ForeignKey("RefBuildingSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingSystemType? RefBuildingSystemType { get; set; }
        [ForeignKey("RefBuildingTechnologyWiringSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingTechnologyWiringSystemType? RefBuildingTechnologyWiringSystemType { get; set; }
        [ForeignKey("RefBuildingVerticalTransportationSystemTypeId")]
        [InverseProperty("BuildingSystemCategories")]
        public virtual RefBuildingVerticalTransportationSystemType? RefBuildingVerticalTransportationSystemType { get; set; }
    }
}
