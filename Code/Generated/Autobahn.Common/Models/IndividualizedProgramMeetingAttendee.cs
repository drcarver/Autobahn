//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingAttendee.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendee
     /// </summary>
    public partial class IndividualizedProgramMeetingAttendee : IIndividualizedProgramMeetingAttendee
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramMeeting"/> model
        /// </summary>
        public Guid IndividualizedProgramMeetingId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeetingAttendee.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeetingAttendee.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
