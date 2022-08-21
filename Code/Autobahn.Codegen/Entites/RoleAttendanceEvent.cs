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
    [Table("RoleAttendanceEvent")]
    public partial class RoleAttendanceEvent
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RoleAttendanceEventId { get; set; }
        /// <summary>
        /// Foreign key - OrganizationPersonRole.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAttendanceEventTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAttendanceStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAbsentAttendanceCategoryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPresentAttendanceCategoryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLeaveEventTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? StartTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? EndTime { get; set; }
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
        [InverseProperty("RoleAttendanceEvents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAbsentAttendanceCategoryId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RefAbsentAttendanceCategory? RefAbsentAttendanceCategory { get; set; }
        [ForeignKey("RefAttendanceEventTypeId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RefAttendanceEventType? RefAttendanceEventType { get; set; }
        [ForeignKey("RefAttendanceStatusId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RefAttendanceStatus? RefAttendanceStatus { get; set; }
        [ForeignKey("RefLeaveEventTypeId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RefLeaveEventType? RefLeaveEventType { get; set; }
        [ForeignKey("RefPresentAttendanceCategoryId")]
        [InverseProperty("RoleAttendanceEvents")]
        public virtual RefPresentAttendanceCategory? RefPresentAttendanceCategory { get; set; }
    }
}
