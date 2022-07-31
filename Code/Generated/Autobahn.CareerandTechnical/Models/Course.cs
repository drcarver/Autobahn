//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   Course.cs
//**********************************************************

using Autobahn.CareerandTechnical.Interfaces;

namespace Autobahn.CareerandTechnical.Models
{
     /// <summary>
     /// The Course
     /// </summary>
    public partial class Course : ICourse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Course.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the Course.SubjectAbbreviation non nullable property
        /// </summary>
        public System.String SubjectAbbreviation { get; set; }

        /// <summary>
        /// Where a specific course lies when it is part of a consecutive sequence of courses. This element should be interpreted as "part 'n' of 'm' parts.
        /// </summary>
    public System.String SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// Defines the Course.InstructionalMinutes nullable property
        /// </summary>
        public System.Int32? InstructionalMinutes { get; set; }

        /// <summary>
        /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
        /// </summary>
    public System.Decimal? CreditValue { get; set; }

        /// <summary>
        /// Defines the Course.CertificationDescription non nullable property
        /// </summary>
        public System.String CertificationDescription { get; set; }

        /// <summary>
        /// Defines the Course.RepeatabilityMaximumNumber nullable property
        /// </summary>
        public System.Int32? RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristics"/> model
        /// </summary>
        public Guid? RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevel"/> model
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get; set; }

        /// <summary>
        /// Defines the Course.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Course.RecordEndDateTime nullable property
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
