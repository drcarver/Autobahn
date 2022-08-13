//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CTE.Models
{
     /// <summary>
     /// The CteCourse Model
     /// </summary>
    public partial class CteCourseModel : AutobahnBase, Interfaces.ICteCourse
    {
        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.String SCEDCourseCode { get; set; }

    }
}
