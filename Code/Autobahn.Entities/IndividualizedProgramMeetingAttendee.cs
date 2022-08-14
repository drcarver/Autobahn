using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramMeetingAttendee")]
    public partial class IndividualizedProgramMeetingAttendee
    {
        public int IndividualizedProgramMeetingAttendeeId { get; set; }

        public int IndividualizedProgramMeetingId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgramMeeting IndividualizedProgramMeeting { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
