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
    [Table("IndividualizedProgramMeeting", Schema = "K12")]
    public partial class IndividualizedProgramMeeting
    {
        public IndividualizedProgramMeeting()
        {
            IndividualizedProgramMeetingAttendees = new HashSet<IndividualizedProgramMeetingAttendee>();
        }

        [Key]
        public int IndividualizedProgramMeetingId { get; set; }
        public int IndividualizedProgramId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MeetingDate { get; set; }
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
        [InverseProperty("IndividualizedProgramMeetings")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramMeetings")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramMeetings")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("IndividualizedProgramMeeting")]
        public virtual ICollection<IndividualizedProgramMeetingAttendee> IndividualizedProgramMeetingAttendees { get; set; }
    }
}
