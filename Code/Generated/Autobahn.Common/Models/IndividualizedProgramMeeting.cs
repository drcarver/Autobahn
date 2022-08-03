//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeeting.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramMeeting
     /// </summary>
    public partial class IndividualizedProgramMeeting : IIndividualizedProgramMeeting
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeeting.MeetingDate nullable property
        /// </summary>
        public System.DateTime? MeetingDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeeting.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeeting.RecordEndDateTime nullable property
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
