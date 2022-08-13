//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentParticipantSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentParticipantSession Interface
     /// </summary>
    public partial interface IAssessmentParticipantSession : IAutobahnBase
    {
        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid AssessmentSessionId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? LocationId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String PlatformUserAgent { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        System.String TimeAssessed { get; set; }

    }
}
