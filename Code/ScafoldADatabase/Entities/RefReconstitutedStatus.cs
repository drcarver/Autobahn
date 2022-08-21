﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefReconstitutedStatus")]
    public partial class RefReconstitutedStatus
    {
        public RefReconstitutedStatus()
        {
            OrganizationFederalAccountabilities = new HashSet<OrganizationFederalAccountability>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefReconstitutedStatusId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefReconstitutedStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefReconstitutedStatus")]
        public virtual ICollection<OrganizationFederalAccountability> OrganizationFederalAccountabilities { get; set; }
    }
}
