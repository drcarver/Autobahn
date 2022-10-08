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
    [Table("K12StudentSession", Schema = "K12")]
    public partial class K12StudentSession
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int K12StudentSessionId { get; set; }
        /// <summary>
        /// Foreign key to OrganizationPersonRole.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// Foreign key to Session.
        /// </summary>
        public int? OrganizationCalendarSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? GradePointAverageGivenSession { get; set; }
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
        [InverseProperty("K12studentSessions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("K12studentSessions")]
        public virtual OrganizationCalendarSession? OrganizationCalendarSession { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentSessions")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentSessions")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
