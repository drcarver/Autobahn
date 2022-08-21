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
    [Table("IEPAuthorizationRejected")]
    public partial class IepauthorizationRejected
    {
        [Key]
        [Column("IEPAuthorizationRejectedId")]
        public int IepauthorizationRejectedId { get; set; }
        [Column("IEPAuthorizationId")]
        public int IepauthorizationId { get; set; }
        public string? PortionDescription { get; set; }
        public string? PortionExplanation { get; set; }
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
        [InverseProperty("IepauthorizationRejecteds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IepauthorizationId")]
        [InverseProperty("IepauthorizationRejecteds")]
        public virtual Iepauthorization Iepauthorization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IepauthorizationRejecteds")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
