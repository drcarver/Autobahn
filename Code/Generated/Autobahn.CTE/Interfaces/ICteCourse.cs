//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   ICteCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CTE.Interfaces
{
     /// <summary>
     /// The ICteCourse Interface
     /// </summary>
    public partial interface ICteCourse : IAutobahnBase
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
        System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

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
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        Guid? RefCurriculumFrameworkTypeId { get; set; }

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
        System.String SCEDCourseCode { get; set; }

    }
}
