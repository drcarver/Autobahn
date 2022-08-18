//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActivityModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearnerActivity Model
     /// </summary>
    public partial class LearnerActivityModel : AutobahnBase, Interfaces.ILearnerActivity
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
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
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Learner Activity Due Date
        /// <para>
        /// The date assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19947">Learner Activity Due Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Learner Activity Due Time
        /// <para>
        /// The time the assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19948">Learner Activity Due Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? DueTime { get; set; }

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
        public System.Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// Learner Activity Maximum Time Allowed
        /// <para>
        /// The time required to complete the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19945">Learner Activity Maximum Time Allowed</a>
        /// </para>
        /// </summary>
        public System.Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
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
        public System.Decimal? PossiblePoints { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlag"/> model
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
        /// Reference to an optional instance of the <see cref="RefLearnerActivityType"/> model
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
        public System.DateTime? ReleaseDate { get; set; }

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
        public System.Decimal? Weight { get; set; }

    }
}
