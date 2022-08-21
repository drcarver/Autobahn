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
    [Table("FacilityDesignConstruction")]
    public partial class FacilityDesignConstruction
    {
        [Key]
        public int FacilityDesignConstructionId { get; set; }
        public int FacilityDesignId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FacilityConstructionDate { get; set; }
        [StringLength(4)]
        public string? FacilityConstructionYear { get; set; }
        [StringLength(30)]
        public string? BuildingAdditionCode { get; set; }
        [StringLength(80)]
        public string? BuildingAdditionDescription { get; set; }
        [StringLength(4)]
        public string? FacilityAdditionYear { get; set; }
        [StringLength(80)]
        public string? BuildingSiteImprovementDescription { get; set; }
        public int? RefBuildingEnergyConservationMeasureTypeId { get; set; }
        public int? RefFacilityConstructionDateTypeId { get; set; }
        public int? RefFacilityConstructionMaterialTypeId { get; set; }
        public int? RefFacilityJointDevelopmentTypeId { get; set; }
        public int? RefFacilitySiteImprovementLocationTypeId { get; set; }
        public int? RefFacilityStandardTypeId { get; set; }
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
        [InverseProperty("FacilityDesignConstructions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityDesignId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual FacilityDesign FacilityDesign { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingEnergyConservationMeasureTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefBuildingEnergyConservationMeasureType? RefBuildingEnergyConservationMeasureType { get; set; }
        [ForeignKey("RefFacilityConstructionDateTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefFacilityConstructionDateType? RefFacilityConstructionDateType { get; set; }
        [ForeignKey("RefFacilityConstructionMaterialTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefFacilityConstructionMaterialType? RefFacilityConstructionMaterialType { get; set; }
        [ForeignKey("RefFacilityJointDevelopmentTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefFacilityJointDevelopmentType? RefFacilityJointDevelopmentType { get; set; }
        [ForeignKey("RefFacilitySiteImprovementLocationTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefFacilitySiteImprovementLocationType? RefFacilitySiteImprovementLocationType { get; set; }
        [ForeignKey("RefFacilityStandardTypeId")]
        [InverseProperty("FacilityDesignConstructions")]
        public virtual RefFacilityStandardType? RefFacilityStandardType { get; set; }
    }
}
