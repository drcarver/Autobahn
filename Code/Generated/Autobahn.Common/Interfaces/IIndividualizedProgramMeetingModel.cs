//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramMeetingModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeetingModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramMeetingModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramMeeting.MeetingDate nullable property
        /// </summary>
        System.DateTime? MeetingDate { get; set; }

    }
}
