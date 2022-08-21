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
    [Table("OrganizationCalendarDay")]
    public partial class OrganizationCalendarDay
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationCalendarDayId { get; set; }
        /// <summary>
        /// Foreign key - OrgainzationCalendar
        /// </summary>
        public int OrganizationCalendarId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(30)]
        public string DayName { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? AlternateDayName { get; set; }
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
        [InverseProperty("OrganizationCalendarDays")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationCalendarId")]
        [InverseProperty("OrganizationCalendarDays")]
        public virtual OrganizationCalendar OrganizationCalendar { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationCalendarDays")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
