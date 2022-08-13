//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramMeeting.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramMeeting Interface
     /// </summary>
    public partial interface IIndividualizedProgramMeeting : IAutobahnBase
    {
        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        System.DateTime? MeetingDate { get; set; }

    }
}
