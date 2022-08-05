//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentParticipantSession.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentParticipantSession
     /// </summary>
    public partial interface IAssessmentParticipantSession : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentParticipantSession.ActualStartDateTime nullable property
        /// </summary>
        System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.ActualEndDateTime nullable property
        /// </summary>
        System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.TimeAssessed non nullable property
        /// </summary>
        System.String TimeAssessed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformType"/> model
        /// </summary>
        Guid? RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.DeliveryDeviceDetails non nullable property
        /// </summary>
        System.String DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.SecurityIssue non nullable property
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.SpecialEventDescription non nullable property
        /// </summary>
        System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        Guid? LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid? AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        Guid AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.AssessmentParticipantSessionDatabaseName non nullable property
        /// </summary>
        System.String AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.AssessmentParticipantSessionGUID non nullable property
        /// </summary>
        System.String AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.PlatformUserAgent non nullable property
        /// </summary>
        System.String PlatformUserAgent { get; set; }

    }
}
