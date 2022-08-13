//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramMeetingAttendeeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendee Model
     /// </summary>
    public partial class IndividualizedProgramMeetingAttendeeModel : AutobahnBase, Interfaces.IIndividualizedProgramMeetingAttendee
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid IndividualizedProgramMeetingId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
