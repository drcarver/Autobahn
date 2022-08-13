//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramMeetingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramMeeting Model
     /// </summary>
    public partial class IndividualizedProgramMeetingModel : AutobahnBase, Interfaces.IIndividualizedProgramMeeting
    {
        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        public System.DateTime? MeetingDate { get; set; }

    }
}
