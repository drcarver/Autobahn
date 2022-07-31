//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   ICourseSection.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The ICourseSection
     /// </summary>
    public partial Interface ICourseSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
    System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the CourseSection.TimeRequiredForCompletion nullable property
        /// </summary>
        System.Decimal? TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </summary>
    System.Boolean? VirtualIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the CourseSection.MaximumCapacity nullable property
        /// </summary>
        System.Int32? MaximumCapacity { get; set; }

        /// <summary>
        /// An indication of the competency definition(s) addressed in the Course Section.
        /// </summary>
    System.String RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryMode"/> model
        /// </summary>
        Guid? RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        Guid? RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCode"/> model
        /// </summary>
        Guid? RefAdvancedPlacementCourseCodeId { get; set; }

        /// <summary>
        /// Defines the CourseSection.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSection.RecordEndDateTime nullable property
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
