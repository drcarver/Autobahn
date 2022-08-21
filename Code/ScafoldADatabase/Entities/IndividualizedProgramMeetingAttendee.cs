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
    [Table("IndividualizedProgramMeetingAttendee")]
    [Index("IndividualizedProgramMeetingId", "OrganizationPersonRoleId", Name = "IX_IndividualizedProgramMeeting_OrganizationPersonRole", IsUnique = true)]
    public partial class IndividualizedProgramMeetingAttendee
    {
        [Key]
        public int IndividualizedProgramMeetingAttendeeId { get; set; }
        public int IndividualizedProgramMeetingId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
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
        [InverseProperty("IndividualizedProgramMeetingAttendees")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramMeetingId")]
        [InverseProperty("IndividualizedProgramMeetingAttendees")]
        public virtual IndividualizedProgramMeeting IndividualizedProgramMeeting { get; set; } = null!;
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("IndividualizedProgramMeetingAttendees")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramMeetingAttendees")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
