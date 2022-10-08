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
    [Table("ServiceProvider", Schema = "Common")]
    public partial class ServiceProvider
    {
        [Key]
        public int ServiceProviderId { get; set; }
        public int OrganizationId { get; set; }
        public int ServiceProvidedId { get; set; }
        public int ServiceStaffId { get; set; }
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
        [InverseProperty("ServiceProviders")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("ServiceProviders")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServiceProviders")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("ServiceProvidedId")]
        [InverseProperty("ServiceProviders")]
        public virtual ServiceProvided ServiceProvided { get; set; } = null!;
        [ForeignKey("ServiceStaffId")]
        [InverseProperty("ServiceProviders")]
        public virtual ServiceStaff ServiceStaff { get; set; } = null!;
    }
}
