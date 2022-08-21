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
    [Table("FacilityManagementPlan")]
    public partial class FacilityManagementPlan
    {
        [Key]
        public int FacilityManagementPlanId { get; set; }
        public int FacilityManagementId { get; set; }
        [StringLength(80)]
        public string? FacilitiesPlanDescription { get; set; }
        public int? RefFacilitiesPlanTypeId { get; set; }
        public int? RefFacilitiesMgmtEmergencyTypeId { get; set; }
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
        [InverseProperty("FacilityManagementPlans")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityManagementId")]
        [InverseProperty("FacilityManagementPlans")]
        public virtual FacilityManagement FacilityManagement { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityManagementPlans")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilitiesMgmtEmergencyTypeId")]
        [InverseProperty("FacilityManagementPlans")]
        public virtual RefFacilitiesMgmtEmergencyType? RefFacilitiesMgmtEmergencyType { get; set; }
        [ForeignKey("RefFacilitiesPlanTypeId")]
        [InverseProperty("FacilityManagementPlans")]
        public virtual RefFacilitiesPlanType? RefFacilitiesPlanType { get; set; }
    }
}
