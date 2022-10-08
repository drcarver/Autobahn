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
    [Table("IEPAuthorizationRejected", Schema = "K12")]
    public partial class IEPAuthorizationRejected
    {
        [Key]
        public int IEPAuthorizationRejectedId { get; set; }
        public int IEPAuthorizationId { get; set; }
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
        [ForeignKey("IEPAuthorizationId")]
        [InverseProperty("IepauthorizationRejecteds")]
        public virtual IEPAuthorization IEPAuthorization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IepauthorizationRejecteds")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
