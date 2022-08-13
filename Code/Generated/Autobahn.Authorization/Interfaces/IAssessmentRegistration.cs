//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentRegistration.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration Interface
     /// </summary>
    public partial interface IAssessmentRegistration : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.Int32? DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.Boolean? LEAFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.Boolean? RetestIndicator { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.Boolean? SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.DateTime? ScorePublishDate { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.Boolean? StateFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.String TestAttemptIdentifier { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        System.String TestingIndicator { get; set; }

    }
}
