//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12Course.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Course Interface
     /// </summary>
    public partial interface IK12Course : IAutobahnBase
    {
        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.Boolean? FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.String FundingProgram { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefK12EndOfCourseRequirementId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        System.String SCEDGradeSpan { get; set; }

    }
}
