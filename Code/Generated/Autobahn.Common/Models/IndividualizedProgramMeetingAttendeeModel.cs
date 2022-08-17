//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingAttendeeModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendee Model
     /// </summary>
    public partial class IndividualizedProgramMeetingAttendeeModel : AutobahnBase, Interfaces.IIndividualizedProgramMeetingAttendee
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramMeeting"/> model
        /// </summary>
        public Guid IndividualizedProgramMeetingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
