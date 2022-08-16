//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentCourseSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCourseSection Interface
     /// </summary>
    public partial interface IK12StudentCourseSection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ExitWithdrawalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradeEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradeValueQualifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsEarned { get; set; }

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
        Guid? RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgressLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TuitionFunded { get; set; }

    }
}
