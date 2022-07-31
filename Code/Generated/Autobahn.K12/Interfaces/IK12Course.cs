//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12Course.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Course
     /// </summary>
    public partial interface IK12Course
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Course"/> model
        /// </summary>
        Guid K12CourseId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// An indication that this course credit is required for a high school diploma.
        /// </summary>
    System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
    System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// The course meets the state definition of a core academic course.
        /// </summary>
    System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
    System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Defines the K12Course.FundingProgram non nullable property
        /// </summary>
        System.String FundingProgram { get; set; }

        /// <summary>
        /// Defines the K12Course.FamilyConsumerSciencesCourseInd nullable property
        /// </summary>
        System.Boolean? FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// The five-digit SCED code. The first two-digits of the code represent the Course Subject Area and the next three digits identify the course number. These identifiers are fairly general but provide enough specificity to identify the course's topic and to distinguish it from other courses in that subject area.
        /// </summary>
    System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// The grade span for which the course is appropriate.
        /// </summary>
    System.String SCEDGradeSpan { get; set; }

        /// <summary>
        /// Department with jurisdiction over this course.
        /// </summary>
    System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
        /// </summary>
        Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevel"/> model
        /// </summary>
        Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
        /// </summary>
        Guid? RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirement"/> model
        /// </summary>
        Guid? RefK12EndOfCourseRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the K12Course.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12Course.RecordEndDateTime nullable property
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
