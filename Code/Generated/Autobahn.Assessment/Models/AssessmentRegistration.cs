//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistration.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentRegistration
     /// </summary>
    public partial class AssessmentRegistration : IAssessmentRegistration
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.CreationDate nullable property
        /// </summary>
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.DaysOfInstructionPriorToAssessment nullable property
        /// </summary>
        public System.Int32? DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.ScorePublishDate nullable property
        /// </summary>
        public System.DateTime? ScorePublishDate { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.TestAttemptIdentifier non nullable property
        /// </summary>
        public System.String TestAttemptIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RetestIndicator nullable property
        /// </summary>
        public System.Boolean? RetestIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.TestingIndicator non nullable property
        /// </summary>
        public System.String TestingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganization"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganization"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.AssessmentRegistrationCompletionStatusDateTime nullable property
        /// </summary>
        public System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.StateFullAcademicYear nullable property
        /// </summary>
        public System.Boolean? StateFullAcademicYear { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.LEAFullAcademicYear nullable property
        /// </summary>
        public System.Boolean? LEAFullAcademicYear { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.SchoolFullAcademicYear nullable property
        /// </summary>
        public System.Boolean? SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicator"/> model
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotTested"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotCompleting"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelToBeAssessed"/> model
        /// </summary>
        public Guid? RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenAssessed"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentRegistrationCompletionStatus"/> model
        /// </summary>
        public Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RecordEndDateTime nullable property
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
