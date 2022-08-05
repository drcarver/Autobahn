//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramMeeting.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeeting
     /// </summary>
    public partial interface IIndividualizedProgramMeeting : IAutobahnBase
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
