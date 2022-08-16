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
         FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FundingProgram { get; set; }

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
         RefBlendedLearningModelTypeId { get; set; }

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
         RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefK12EndOfCourseRequirementId { get; set; }

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
         RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SCEDCourseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SCEDGradeSpan { get; set; }

    }
}
