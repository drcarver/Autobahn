//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearnerActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearnerActivity Model
     /// </summary>
    public partial class LearnerActivityModel : AutobahnBase, Interfaces.ILearnerActivity
    {
        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.TimeSpan? DueTime { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? PossiblePoints { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String Prerequisite { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String RubricUrl { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? Weight { get; set; }

    }
}
