//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearnerActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearnerActivity Interface
     /// </summary>
    public partial interface ILearnerActivity : IAutobahnBase
    {
        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.DateTime? DueDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.TimeSpan? DueTime { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.Decimal? MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.Decimal? MaximumTimeAllowed { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.Decimal? PossiblePoints { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.String Prerequisite { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.String RubricUrl { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        System.Decimal? Weight { get; set; }

    }
}
