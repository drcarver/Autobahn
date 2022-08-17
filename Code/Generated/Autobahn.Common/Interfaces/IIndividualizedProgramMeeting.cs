//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramMeeting.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeeting Interface
     /// </summary>
    public partial interface IIndividualizedProgramMeeting : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Meeting Date
        /// <para>
        /// The date on which a child's service plan meeting is held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
        /// </para>
        /// </summary>
        System.DateTime? MeetingDate { get; set; }

    }
}
