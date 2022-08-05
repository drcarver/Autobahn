//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   ICteCourse.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CareerandTechnical.Interfaces
{
     /// <summary>
     /// The ICteCourse
     /// </summary>
    public partial interface ICteCourse : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Defines the CteCourse.AvailableCarnegieUnitCredit nullable property
        /// </summary>
        System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the CteCourse.HighSchoolCourseRequirement nullable property
        /// </summary>
        System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Defines the CteCourse.CoreAcademicCourse nullable property
        /// </summary>
        System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Defines the CteCourse.CourseAlignedWithStandards nullable property
        /// </summary>
        System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Defines the CteCourse.SCEDCourseCode non nullable property
        /// </summary>
        System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// Defines the CteCourse.CourseDepartmentName non nullable property
        /// </summary>
        System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

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

    }
}
