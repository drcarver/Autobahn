//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistration Model
     /// </summary>
    public partial class AssessmentRegistrationModel : AutobahnBase, Interfaces.IAssessmentRegistration
    {
        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.Int32? DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.Boolean? LEAFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.Boolean? RetestIndicator { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.Boolean? SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.DateTime? ScorePublishDate { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.Boolean? StateFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.String TestAttemptIdentifier { get; set; }

        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public System.String TestingIndicator { get; set; }

    }
}
