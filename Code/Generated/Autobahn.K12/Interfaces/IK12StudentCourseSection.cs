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
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.DateTime? ExitWithdrawalDate { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.String GradeEarned { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        System.Boolean? TuitionFunded { get; set; }

    }
}
