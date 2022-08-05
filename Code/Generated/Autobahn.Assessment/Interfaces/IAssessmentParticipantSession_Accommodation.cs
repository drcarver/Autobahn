//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentParticipantSession_Accommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentParticipantSession_Accommodation
     /// </summary>
    public partial interface IAssessmentParticipantSession_Accommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

    }
}
