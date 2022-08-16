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
        /// 
        /// </summary>
         AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CoreAcademicCourse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CourseDepartmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SCEDCourseCode { get; set; }

    }
}
