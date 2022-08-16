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
        /// 
        /// </summary>
        public Guid? MeetingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
