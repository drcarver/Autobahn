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
    [Table("FacilityEnergy", Schema = "Facilities")]
    public partial class FacilityEnergy
    {
        [Key]
        public int FacilityEnergyId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(60)]
        public string? BuildingEnergyServiceCompanyName { get; set; }
        public int? RefBuildingEnergySourceTypeId { get; set; }
        public int? RefFacilityUtilityProviderTypeId { get; set; }
        public int? RefFacilityUtilityTypeId { get; set; }
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
        [InverseProperty("FacilityEnergies")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityEnergies")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityEnergies")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingEnergySourceTypeId")]
        [InverseProperty("FacilityEnergies")]
        public virtual RefBuildingEnergySourceType? RefBuildingEnergySourceType { get; set; }
        [ForeignKey("RefFacilityUtilityProviderTypeId")]
        [InverseProperty("FacilityEnergies")]
        public virtual RefFacilityUtilityProviderType? RefFacilityUtilityProviderType { get; set; }
        [ForeignKey("RefFacilityUtilityTypeId")]
        [InverseProperty("FacilityEnergies")]
        public virtual RefFacilityUtilityType? RefFacilityUtilityType { get; set; }
    }
}
