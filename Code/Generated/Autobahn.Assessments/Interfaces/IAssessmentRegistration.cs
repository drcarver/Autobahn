//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessmentRegistration.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration
     /// </summary>
    public partial interface IAssessmentRegistration
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.CreationDate nullable property
        /// </summary>
        System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.DaysOfInstructionPriorToAssessment nullable property
        /// </summary>
        System.Int32? DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.ScorePublishDate nullable property
        /// </summary>
        System.DateTime? ScorePublishDate { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.TestAttemptIdentifier non nullable property
        /// </summary>
        System.String TestAttemptIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RetestIndicator nullable property
        /// </summary>
        System.Boolean? RetestIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.TestingIndicator non nullable property
        /// </summary>
        System.String TestingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganization"/> model
        /// </summary>
        Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganization"/> model
        /// </summary>
        Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// The date and time the completion and scoring status was changed for an instance of a person taking an assessment.
        /// </summary>
    System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// An indication of whether a student was in membership in the state education unit for a full academic year, according to the state’s definition of Full Academic Year.
        /// </summary>
    System.Boolean? StateFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student was in membership in the LEA education unit for a full academic year, according to the state’s definition of Full Academic Year.
        /// </summary>
    System.Boolean? LEAFullAcademicYear { get; set; }

        /// <summary>
        /// An indication of whether a student was in membership in the school education unit for a full academic year, according to the state’s definition of Full Academic Year.
        /// </summary>
    System.Boolean? SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicator"/> model
        /// </summary>
        Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotTested"/> model
        /// </summary>
        Guid? RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotCompleting"/> model
        /// </summary>
        Guid? RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelToBeAssessed"/> model
        /// </summary>
        Guid? RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenAssessed"/> model
        /// </summary>
        Guid? RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentRegistrationCompletionStatus"/> model
        /// </summary>
        Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentRegistration.RecordEndDateTime nullable property
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
