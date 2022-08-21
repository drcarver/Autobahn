using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefOrganizationType")]
    public partial class RefOrganizationType
    {
        public RefOrganizationType()
        {
            OrganizationDetails = new HashSet<OrganizationDetail>();
            RefOrganizationIndicators = new HashSet<RefOrganizationIndicator>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefOrganizationTypeId { get; set; }
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
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        public int? RefOrganizationElementTypeId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefOrganizationTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [ForeignKey("RefOrganizationElementTypeId")]
        [InverseProperty("RefOrganizationTypes")]
        public virtual RefOrganizationElementType? RefOrganizationElementType { get; set; }
        [InverseProperty("RefOrganizationType")]
        public virtual ICollection<OrganizationDetail> OrganizationDetails { get; set; }
        [InverseProperty("RefOrganizationType")]
        public virtual ICollection<RefOrganizationIndicator> RefOrganizationIndicators { get; set; }
    }
}
