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
    [Table("FacilityLocation", Schema = "Facilities")]
    [Index("FacilityId", "LocationId", Name = "IX_Facility_Location", IsUnique = true)]
    public partial class FacilityLocation
    {
        [Key]
        public int FacilityLocationId { get; set; }
        public int FacilityId { get; set; }
        public int LocationId { get; set; }
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
        [InverseProperty("FacilityLocations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityLocations")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("LocationId")]
        [InverseProperty("FacilityLocations")]
        public virtual Location Location { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityLocations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
