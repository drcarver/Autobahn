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
    [Table("RefRoleStatus", Schema = "Role")]
    public partial class RefRoleStatus
    {
        public RefRoleStatus()
        {
            RoleStatuses = new HashSet<RoleStatus>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefRoleStatusId { get; set; }
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
        /// <summary>
        /// List of role status types.
        /// </summary>
        public int? RefRoleStatusTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefRoleStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [ForeignKey("RefRoleStatusTypeId")]
        [InverseProperty("RefRoleStatuses")]
        public virtual RefRoleStatusType? RefRoleStatusType { get; set; }
        [InverseProperty("RefRoleStatus")]
        public virtual ICollection<RoleStatus> RoleStatuses { get; set; }
    }
}
