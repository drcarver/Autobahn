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
    [Table("OrganizationOperationalStatus")]
    public partial class OrganizationOperationalStatus
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationOperationalStatusId { get; set; }
        /// <summary>
        /// Surrogate key from Organization.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefOperationalStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? OperationalStatusEffectiveDate { get; set; }
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
        [InverseProperty("OrganizationOperationalStatuses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationOperationalStatuses")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationOperationalStatuses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefOperationalStatusId")]
        [InverseProperty("OrganizationOperationalStatuses")]
        public virtual RefOperationalStatus RefOperationalStatus { get; set; } = null!;
    }
}
