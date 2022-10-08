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
    [Table("FacilitySite", Schema = "Facilities")]
    public partial class FacilitySite
    {
        [Key]
        public int FacilitySiteId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(20)]
        public string? FacilitySiteIdentifier { get; set; }
        [Column(TypeName = "decimal(9, 1)")]
        public decimal? FacilitySiteArea { get; set; }
        public int? RefBuildingSiteUseRestrictionsTypeId { get; set; }
        public int? RefFacilitySiteOutdoorAreaTypeId { get; set; }
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
        [InverseProperty("FacilitySites")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilitySites")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilitySites")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingSiteUseRestrictionsTypeId")]
        [InverseProperty("FacilitySites")]
        public virtual RefBuildingSiteUseRestrictionsType? RefBuildingSiteUseRestrictionsType { get; set; }
        [ForeignKey("RefFacilitySiteOutdoorAreaTypeId")]
        [InverseProperty("FacilitySites")]
        public virtual RefFacilitySiteOutdoorAreaType? RefFacilitySiteOutdoorAreaType { get; set; }
    }
}
