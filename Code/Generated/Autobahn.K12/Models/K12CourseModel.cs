//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Course Model
     /// </summary>
    public partial class K12CourseModel : AutobahnBase, Interfaces.IK12Course
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
        public System.Boolean? FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.String FundingProgram { get; set; }

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
        public Guid? RefBlendedLearningModelTypeId { get; set; }

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
        public Guid? RefCourseInteractionModeId { get; set; }

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
        public Guid? RefK12EndOfCourseRequirementId { get; set; }

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
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </summary>
        public System.String SCEDGradeSpan { get; set; }

    }
}
