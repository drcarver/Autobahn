//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramMeetingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramMeeting Model
     /// </summary>
    public partial class IndividualizedProgramMeetingModel : AutobahnBase, Interfaces.IIndividualizedProgramMeeting
    {
        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        public System.DateTime? MeetingDate { get; set; }

    }
}
