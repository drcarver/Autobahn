//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramMeetingAttendee.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeetingAttendee
     /// </summary>
    public partial interface IIndividualizedProgramMeetingAttendee : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramMeeting"/> model
        /// </summary>
        Guid IndividualizedProgramMeetingId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
