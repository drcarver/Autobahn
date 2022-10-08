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
    [Table("FacilityRelationship", Schema = "Facilities")]
    [Index("ParentFacilityId", "FacilityId", Name = "IX_Facility_Facility", IsUnique = true)]
    public partial class FacilityRelationship
    {
        [Key]
        public int FacilityRelationshipId { get; set; }
        public int ParentFacilityId { get; set; }
        public int FacilityId { get; set; }
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
        [InverseProperty("FacilityRelationships")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityRelationshipFacilities")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("ParentFacilityId")]
        [InverseProperty("FacilityRelationshipParentFacilities")]
        public virtual Facility ParentFacility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityRelationships")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
