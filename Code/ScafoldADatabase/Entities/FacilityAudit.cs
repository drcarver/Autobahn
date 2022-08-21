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
    [Table("FacilityAudit")]
    public partial class FacilityAudit
    {
        [Key]
        public int FacilityAuditId { get; set; }
        public int FacilityId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FacilityAuditDate { get; set; }
        public int? RefFacilityAuditTypeId { get; set; }
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
        [InverseProperty("FacilityAudits")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityAudits")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityAudits")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityAuditTypeId")]
        [InverseProperty("FacilityAudits")]
        public virtual RefFacilityAuditType? RefFacilityAuditType { get; set; }
    }
}
