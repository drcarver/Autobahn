//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12Course.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Course
     /// </summary>
    public partial interface IK12Course : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Defines the K12Course.HighSchoolCourseRequirement nullable property
        /// </summary>
        System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Defines the K12Course.AvailableCarnegieUnitCredit nullable property
        /// </summary>
        System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the K12Course.CoreAcademicCourse nullable property
        /// </summary>
        System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Defines the K12Course.CourseAlignedWithStandards nullable property
        /// </summary>
        System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Defines the K12Course.FundingProgram non nullable property
        /// </summary>
        System.String FundingProgram { get; set; }

        /// <summary>
        /// Defines the K12Course.FamilyConsumerSciencesCourseInd nullable property
        /// </summary>
        System.Boolean? FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// Defines the K12Course.SCEDCourseCode non nullable property
        /// </summary>
        System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// Defines the K12Course.SCEDGradeSpan non nullable property
        /// </summary>
        System.String SCEDGradeSpan { get; set; }

        /// <summary>
        /// Defines the K12Course.CourseDepartmentName non nullable property
        /// </summary>
        System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

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

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
        /// </summary>
        Guid? RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirement"/> model
        /// </summary>
        Guid? RefK12EndOfCourseRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
