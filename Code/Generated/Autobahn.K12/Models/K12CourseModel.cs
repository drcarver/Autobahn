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
        public  FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FundingProgram { get; set; }

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
        public  RefBlendedLearningModelTypeId { get; set; }

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
        public  RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefK12EndOfCourseRequirementId { get; set; }

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
        public  RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SCEDCourseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SCEDGradeSpan { get; set; }

    }
}
