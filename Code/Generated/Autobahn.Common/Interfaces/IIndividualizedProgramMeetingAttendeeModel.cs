//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramMeetingAttendeeModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeetingAttendeeModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramMeetingAttendeeModel : IAutobahnBase
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
