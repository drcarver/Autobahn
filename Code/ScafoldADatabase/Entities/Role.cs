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
    [Table("Role")]
    public partial class Role
    {
        public Role()
        {
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RoleId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Name { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefRoleId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("Roles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Roles")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("Roles")]
        public virtual Organization? RefJurisdiction { get; set; }
        [ForeignKey("RefRoleId")]
        [InverseProperty("Roles")]
        public virtual RefRole? RefRole { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }
    }
}
