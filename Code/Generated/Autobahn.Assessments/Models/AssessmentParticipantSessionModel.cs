//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentParticipantSession Model
     /// </summary>
    public partial class AssessmentParticipantSessionModel : AutobahnBase, Interfaces.IAssessmentParticipantSession
    {
        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid AssessmentSessionId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String PlatformUserAgent { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String TimeAssessed { get; set; }

    }
}
