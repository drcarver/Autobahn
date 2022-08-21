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
    [Table("OrganizationCalendar")]
    public partial class OrganizationCalendar
    {
        public OrganizationCalendar()
        {
            OrganizationCalendarDays = new HashSet<OrganizationCalendarDay>();
            OrganizationCalendarEvents = new HashSet<OrganizationCalendarEvent>();
            OrganizationCalendarSessions = new HashSet<OrganizationCalendarSession>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationCalendarId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? CalendarCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string CalendarDescription { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4)]
        public string? CalendarYear { get; set; }
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
        [InverseProperty("OrganizationCalendars")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationCalendars")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationCalendars")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("OrganizationCalendar")]
        public virtual ICollection<OrganizationCalendarDay> OrganizationCalendarDays { get; set; }
        [InverseProperty("OrganizationCalendar")]
        public virtual ICollection<OrganizationCalendarEvent> OrganizationCalendarEvents { get; set; }
        [InverseProperty("OrganizationCalendar")]
        public virtual ICollection<OrganizationCalendarSession> OrganizationCalendarSessions { get; set; }
    }
}
