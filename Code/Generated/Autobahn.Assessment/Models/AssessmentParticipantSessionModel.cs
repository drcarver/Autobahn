//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentParticipantSession Model
     /// </summary>
    public partial class AssessmentParticipantSessionModel : AutobahnBase, Interfaces.IAssessmentParticipantSessionModel
    {
        /// <summary>
        /// Defines the AssessmentParticipantSession.ActualStartDateTime nullable property
        /// </summary>
        public System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.ActualEndDateTime nullable property
        /// </summary>
        public System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.TimeAssessed non nullable property
        /// </summary>
        public System.String TimeAssessed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformType"/> model
        /// </summary>
        public Guid? RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.DeliveryDeviceDetails non nullable property
        /// </summary>
        public System.String DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.SecurityIssue non nullable property
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.SpecialEventDescription non nullable property
        /// </summary>
        public System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid? AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        public Guid AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.AssessmentParticipantSessionDatabaseName non nullable property
        /// </summary>
        public System.String AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.AssessmentParticipantSessionGUID non nullable property
        /// </summary>
        public System.String AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// Defines the AssessmentParticipantSession.PlatformUserAgent non nullable property
        /// </summary>
        public System.String PlatformUserAgent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
