//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerActivity.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerActivity
     /// </summary>
    public partial interface ILearnerActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Prerequisite non nullable property
        /// </summary>
        System.String Prerequisite { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityType"/> model
        /// </summary>
        Guid? RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RubricUrl non nullable property
        /// </summary>
        System.String RubricUrl { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.CreationDate nullable property
        /// </summary>
        System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.MaximumTimeAllowed nullable property
        /// </summary>
        System.Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.DueDate nullable property
        /// </summary>
        System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.DueTime nullable property
        /// </summary>
        System.TimeSpan? DueTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.MaximumAttemptsAllowed nullable property
        /// </summary>
        System.Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlag"/> model
        /// </summary>
        Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.ReleaseDate nullable property
        /// </summary>
        System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Weight nullable property
        /// </summary>
        System.Decimal? Weight { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.PossiblePoints nullable property
        /// </summary>
        System.Decimal? PossiblePoints { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganization"/> model
        /// </summary>
        Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganization"/> model
        /// </summary>
        Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RecordEndDateTime nullable property
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
