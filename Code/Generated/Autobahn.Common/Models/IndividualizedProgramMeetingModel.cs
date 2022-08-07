//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramMeeting Model
     /// </summary>
    public partial class IndividualizedProgramMeetingModel : AutobahnBase, Interfaces.IIndividualizedProgramMeetingModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
