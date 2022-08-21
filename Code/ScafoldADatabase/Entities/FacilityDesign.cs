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
    [Table("FacilityDesign")]
    public partial class FacilityDesign
    {
        public FacilityDesign()
        {
            FacilityDesignConstructions = new HashSet<FacilityDesignConstruction>();
            FacilitySchoolDesigns = new HashSet<FacilitySchoolDesign>();
        }

        [Key]
        public int FacilityDesignId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(45)]
        public string? BuildingArchitectName { get; set; }
        [StringLength(60)]
        public string? BuildingArchitecturalFirmName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }
        public int? RefBuildingDesignTypeId { get; set; }
        public int? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }
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
        [InverseProperty("FacilityDesigns")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityDesigns")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityDesigns")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingDesignTypeId")]
        [InverseProperty("FacilityDesigns")]
        public virtual RefBuildingDesignType? RefBuildingDesignType { get; set; }
        [ForeignKey("RefBuildingEnvOrEnergyPerformanceRatingCatId")]
        [InverseProperty("FacilityDesigns")]
        public virtual RefBuildingEnvOrEnergyPerformanceRatingCat? RefBuildingEnvOrEnergyPerformanceRatingCat { get; set; }
        [InverseProperty("FacilityDesign")]
        public virtual ICollection<FacilityDesignConstruction> FacilityDesignConstructions { get; set; }
        [InverseProperty("FacilityDesign")]
        public virtual ICollection<FacilitySchoolDesign> FacilitySchoolDesigns { get; set; }
    }
}
