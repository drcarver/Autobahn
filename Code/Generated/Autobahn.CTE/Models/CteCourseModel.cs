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
        /// 
        /// </summary>
        public  AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CoreAcademicCourse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CourseDepartmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SCEDCourseCode { get; set; }

    }
}
