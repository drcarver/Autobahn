//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The LearnerActivity Model
     /// </summary>
    public partial class LearnerActivityModel : ILearnerActivity
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region ILearnerActivity
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Learner Activity Creation Date
        /// <para>
        /// The creation date of the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19944">Learner Activity Creation Date</a>
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Learner Activity Due Date
        /// <para>
        /// The date assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19947">Learner Activity Due Date</a>
        /// </para>
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Learner Activity Due Time
        /// <para>
        /// The time the assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19948">Learner Activity Due Time</a>
        /// </para>
        /// </summary>
        public TimeSpan? DueTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Learner Activity Maximum Attempts Allowed
        /// <para>
        /// The number attempts a student may make on this assignment. Assumed to be unlimited if zero or omitted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19949">Learner Activity Maximum Attempts Allowed</a>
        /// </para>
        /// </summary>
        public Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// Learner Activity Maximum Time Allowed
        /// <para>
        /// The time required to complete the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19945">Learner Activity Maximum Time Allowed</a>
        /// </para>
        /// </summary>
        public Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Learner Activity Possible Points
        /// <para>
        /// The number of possible points for an assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19953">Learner Activity Possible Points</a>
        /// </para>
        /// </summary>
        public Decimal? PossiblePoints { get; set; }

        /// <summary>
        /// Learner Activity Prerequisite
        /// <para>
        /// The description of the skills or competencies the student must have to engage in assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19942">Learner Activity Prerequisite</a>
        /// </para>
        /// </summary>
        public System.String Prerequisite { get; set; }

        /// <summary>
        /// Learner Activity Language
        /// <para>
        /// The default language used for the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19939">Learner Activity Language</a>
        /// </para>
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Learner Activity Add to Grade Book Flag
        /// <para>
        /// Identifies the assignment as one that is graded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19950">Learner Activity Add to Grade Book Flag</a>
        /// </para>
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// Learner Activity Maximum Time Allowed Unit
        /// <para>
        /// The unit of time of the�Maximum Time Allowed�value.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19946">Learner Activity Maximum Time Allowed Unit</a>
        /// </para>
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// Learner Activity Type
        /// <para>
        /// The type of work assigned to the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
        /// </para>
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// Learner Activity Release Date
        /// <para>
        /// The date the student was informed about an assignment or that an automated system displays the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19951">Learner Activity Release Date</a>
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Learner Activity Rubric URL
        /// <para>
        /// The Uniform Resource Locator pointing to a rubric that may be used to evaluate learner performance on the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19954">Learner Activity Rubric URL</a>
        /// </para>
        /// </summary>
        public System.String RubricUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Learner Activity Title
        /// <para>
        /// The title�for work assigned to the learner, which can comprise of learning resources, activities, and assessments.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19940">Learner Activity Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Learner Activity Weight
        /// <para>
        /// The percentage weight of the assignment during the particular course or term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19952">Learner Activity Weight</a>
        /// </para>
        /// </summary>
        public Decimal? Weight { get; set; }

        #endregion
    }
}