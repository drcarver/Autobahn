//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramMeeting Model
     /// </summary>
    public partial class IndividualizedProgramMeetingModel : AutobahnBase, Interfaces.IIndividualizedProgramMeeting
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Meeting Date
        /// <para>
        /// The date on which a child's service plan meeting is held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? MeetingDate { get; set; }

    }
}
