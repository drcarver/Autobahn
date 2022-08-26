//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentParticipantSessionAccommodation.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentParticipantSessionAccommodation Interface
     /// </summary>
    public partial interface IAssessmentParticipantSessionAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
        /// </summary>
        Guid AssessmentParticipantSessionId { get; set; }

    }
}
