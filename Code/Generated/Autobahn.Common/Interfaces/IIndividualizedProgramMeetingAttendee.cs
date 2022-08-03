//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramMeetingAttendee.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeetingAttendee
     /// </summary>
    public partial interface IIndividualizedProgramMeetingAttendee
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramMeeting"/> model
        /// </summary>
        Guid IndividualizedProgramMeetingId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeetingAttendee.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeetingAttendee.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
