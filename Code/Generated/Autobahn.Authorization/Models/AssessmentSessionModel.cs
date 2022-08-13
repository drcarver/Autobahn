//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentSession Model
     /// </summary>
    public partial class AssessmentSessionModel : AutobahnBase, Interfaces.IAssessmentSession
    {
        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String Location { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ScheduledEndDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ScheduledStartDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? School_OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String SpecialEventDescription { get; set; }

    }
}
