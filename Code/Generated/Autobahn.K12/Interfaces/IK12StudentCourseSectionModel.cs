//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentCourseSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCourseSectionModel Interface
     /// </summary>
    public partial interface IK12StudentCourseSectionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.GradeEarned non nullable property
        /// </summary>
        System.String GradeEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.GradeValueQualifier non nullable property
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.NumberOfCreditsAttempted nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.NumberOfCreditsEarned nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.TuitionFunded nullable property
        /// </summary>
        System.Boolean? TuitionFunded { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.ExitWithdrawalDate nullable property
        /// </summary>
        System.DateTime? ExitWithdrawalDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
        /// </summary>
        Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
        /// </summary>
        Guid? RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
        /// </summary>
        Guid? RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

    }
}
