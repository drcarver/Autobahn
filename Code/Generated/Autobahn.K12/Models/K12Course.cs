//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12Course.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Course
     /// </summary>
    public partial class K12Course : IK12Course
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Defines the K12Course.HighSchoolCourseRequirement nullable property
        /// </summary>
        public System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Defines the K12Course.AvailableCarnegieUnitCredit nullable property
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the K12Course.CoreAcademicCourse nullable property
        /// </summary>
        public System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Defines the K12Course.CourseAlignedWithStandards nullable property
        /// </summary>
        public System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Defines the K12Course.FundingProgram non nullable property
        /// </summary>
        public System.String FundingProgram { get; set; }

        /// <summary>
        /// Defines the K12Course.FamilyConsumerSciencesCourseInd nullable property
        /// </summary>
        public System.Boolean? FamilyConsumerSciencesCourseInd { get; set; }

        /// <summary>
        /// Defines the K12Course.SCEDCourseCode non nullable property
        /// </summary>
        public System.String SCEDCourseCode { get; set; }

        /// <summary>
        /// Defines the K12Course.SCEDGradeSpan non nullable property
        /// </summary>
        public System.String SCEDGradeSpan { get; set; }

        /// <summary>
        /// Defines the K12Course.CourseDepartmentName non nullable property
        /// </summary>
        public System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
        /// </summary>
        public Guid? RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirement"/> model
        /// </summary>
        public Guid? RefK12EndOfCourseRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the K12Course.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12Course.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
