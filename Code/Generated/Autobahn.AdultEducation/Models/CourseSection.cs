//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   CourseSection.cs
//**********************************************************

using Autobahn.AdultEducation.Interfaces;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The CourseSection
     /// </summary>
    public partial class CourseSection : ICourseSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
    public System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the CourseSection.TimeRequiredForCompletion nullable property
        /// </summary>
        public System.Decimal? TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </summary>
    public System.Boolean? VirtualIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the CourseSection.MaximumCapacity nullable property
        /// </summary>
        public System.Int32? MaximumCapacity { get; set; }

        /// <summary>
        /// An indication of the competency definition(s) addressed in the Course Section.
        /// </summary>
    public System.String RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryMode"/> model
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCode"/> model
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

        /// <summary>
        /// Defines the CourseSection.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSection.RecordEndDateTime nullable property
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
