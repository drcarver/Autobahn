//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   CteCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CareerandTechnical.Models
{
     /// <summary>
     /// The CteCourse Model
     /// </summary>
    public partial class CteCourseModel : AutobahnBase, Interfaces.ICteCourseModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Defines the CteCourse.AvailableCarnegieUnitCredit nullable property
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the CteCourse.HighSchoolCourseRequirement nullable property
        /// </summary>
        public System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Defines the CteCourse.CoreAcademicCourse nullable property
        /// </summary>
        public System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Defines the CteCourse.CourseAlignedWithStandards nullable property
        /// </summary>
        public System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Defines the CteCourse.SCEDCourseCode non nullable property
        /// </summary>
        public System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// Defines the CteCourse.CourseDepartmentName non nullable property
        /// </summary>
        public System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevel"/> model
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
