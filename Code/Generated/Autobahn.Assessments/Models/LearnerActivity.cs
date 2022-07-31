//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   LearnerActivity.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerActivity
     /// </summary>
    public partial class LearnerActivity : ILearnerActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivity"/> model
        /// </summary>
        public Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Prerequisite non nullable property
        /// </summary>
        public System.String Prerequisite { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityType"/> model
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RubricUrl non nullable property
        /// </summary>
        public System.String RubricUrl { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.CreationDate nullable property
        /// </summary>
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.MaximumTimeAllowed nullable property
        /// </summary>
        public System.Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.DueDate nullable property
        /// </summary>
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.DueTime nullable property
        /// </summary>
        public System.TimeSpan? DueTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.MaximumAttemptsAllowed nullable property
        /// </summary>
        public System.Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlag"/> model
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.ReleaseDate nullable property
        /// </summary>
        public System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.Weight nullable property
        /// </summary>
        public System.Decimal? Weight { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.PossiblePoints nullable property
        /// </summary>
        public System.Decimal? PossiblePoints { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganization"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganization"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity.RecordEndDateTime nullable property
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
