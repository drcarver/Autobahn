//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSession Interface
     /// </summary>
    public partial interface IAssessmentSession : IAutobahnBase
    {
        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.String Location { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.DateTime? ScheduledEndDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.DateTime? ScheduledStartDateTime { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? School_OrganizationId { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        System.String SpecialEventDescription { get; set; }

    }
}
