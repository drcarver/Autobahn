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
    [Table("RefCharterSchoolManagementOrganizationType", Schema = "K12")]
    public partial class RefCharterSchoolManagementOrganizationType
    {
        public RefCharterSchoolManagementOrganizationType()
        {
            K12charterSchoolManagementOrganizations = new HashSet<K12CharterSchoolManagementOrganization>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefCharterSchoolManagementOrganizationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(60)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefCharterSchoolManagementOrganizationTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefCharterSchoolManagementOrganizationType")]
        public virtual ICollection<K12CharterSchoolManagementOrganization> K12charterSchoolManagementOrganizations { get; set; }
    }
}
