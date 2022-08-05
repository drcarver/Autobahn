//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSession_Accommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentParticipantSession_Accommodation
     /// </summary>
    public partial class AssessmentParticipantSession_Accommodation : AutobahnBase, Interfaces.IAssessmentParticipantSession_Accommodation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
