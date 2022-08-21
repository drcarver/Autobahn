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
    [Table("FacilityHazard")]
    public partial class FacilityHazard
    {
        [Key]
        public int FacilityHazardId { get; set; }
        public int FacilityId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }
        [StringLength(60)]
        public string? FacilityLocationOfHazardousMaterials { get; set; }
        public string? FacilityNearbyEnvHazardDescription { get; set; }
        [StringLength(80)]
        public string? HazardousMaterialOrConditionDescription { get; set; }
        [Column(TypeName = "date")]
        public DateTime? HazardousMaterialOrConditionTestingDate { get; set; }
        public int? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }
        public int? RefFacilityNaturallyOccurringHazardTypeId { get; set; }
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
        [InverseProperty("FacilityHazards")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityHazards")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityHazards")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityHazardousMaterialsOrCondTypeId")]
        [InverseProperty("FacilityHazards")]
        public virtual RefFacilityHazardousMaterialsOrCondType? RefFacilityHazardousMaterialsOrCondType { get; set; }
        [ForeignKey("RefFacilityNaturallyOccurringHazardTypeId")]
        [InverseProperty("FacilityHazards")]
        public virtual RefFacilityNaturallyOccurringHazardType? RefFacilityNaturallyOccurringHazardType { get; set; }
    }
}
