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
    [Table("RefOrganizationIndicator", Schema = "Organization")]
    public partial class RefOrganizationIndicator
    {
        public RefOrganizationIndicator()
        {
            OrganizationIndicators = new HashSet<OrganizationIndicator>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefOrganizationIndicatorId { get; set; }
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
        /// <summary>
        /// Indicators may only apply to some types of organizations.
        /// </summary>
        public int? RefOrganizationTypeId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefOrganizationIndicators")]
        public virtual Organization? RefJurisdiction { get; set; }
        [ForeignKey("RefOrganizationTypeId")]
        [InverseProperty("RefOrganizationIndicators")]
        public virtual RefOrganizationType? RefOrganizationType { get; set; }
        [InverseProperty("RefOrganizationIndicator")]
        public virtual ICollection<OrganizationIndicator> OrganizationIndicators { get; set; }
    }
}
