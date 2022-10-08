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
    [Table("FacilityCompliance", Schema = "Facilities")]
    public partial class FacilityCompliance
    {
        [Key]
        public int FacilityComplianceId { get; set; }
        public int? FacilityMandateId { get; set; }
        public int? BuildingSystemComponentId { get; set; }
        [StringLength(80)]
        public string? FacilityComplianceName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FacilityComplianceDeterminationDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureCheckDate { get; set; }
        [StringLength(80)]
        public string? FacilityComponentDeficiencyDescription { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }
        [StringLength(35)]
        public string? FacilityInspectionScoreResultDescription { get; set; }
        [StringLength(80)]
        public string? FacilityInspectionViolationDescription { get; set; }
        public int? RefFacilityComplianceStatusId { get; set; }
        public int? RefFacilityMaintStandardTypeId { get; set; }
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
        [InverseProperty("FacilityCompliances")]
        public virtual BuildingSystemComponent? BuildingSystemComponent { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("FacilityCompliances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityMandateId")]
        [InverseProperty("FacilityCompliances")]
        public virtual FacilityMandate? FacilityMandate { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityCompliances")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityComplianceStatusId")]
        [InverseProperty("FacilityCompliances")]
        public virtual RefFacilityComplianceStatus? RefFacilityComplianceStatus { get; set; }
        [ForeignKey("RefFacilityMaintStandardTypeId")]
        [InverseProperty("FacilityCompliances")]
        public virtual RefFacilityMaintStandardType? RefFacilityMaintStandardType { get; set; }
    }
}
