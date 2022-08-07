//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingAttendeeModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendee Model
     /// </summary>
    public partial class IndividualizedProgramMeetingAttendeeModel : AutobahnBase, Interfaces.IIndividualizedProgramMeetingAttendeeModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
