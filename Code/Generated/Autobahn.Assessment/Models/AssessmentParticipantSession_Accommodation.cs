//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSession_Accommodation.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentParticipantSession_Accommodation
     /// </summary>
    public partial class AssessmentParticipantSession_Accommodation : IAssessmentParticipantSession_Accommodation
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
        /// Defines the AssessmentParticipantSession_Accommodation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession_Accommodation.RecordEndDateTime nullable property
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
