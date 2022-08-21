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
    [Table("ELStaffAssignment")]
    public partial class ElstaffAssignment
    {
        [Key]
        [Column("ELStaffAssignmentId")]
        public int ElstaffAssignmentId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool ItinerantProvider { get; set; }
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
        [InverseProperty("ElstaffAssignments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ElstaffAssignments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElstaffAssignments")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
