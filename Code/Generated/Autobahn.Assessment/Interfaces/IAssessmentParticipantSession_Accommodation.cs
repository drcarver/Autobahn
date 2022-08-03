//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentParticipantSession_Accommodation.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentParticipantSession_Accommodation
     /// </summary>
    public partial interface IAssessmentParticipantSession_Accommodation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession_Accommodation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession_Accommodation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
