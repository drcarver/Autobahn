//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSection.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSection
     /// </summary>
    public partial class K12StudentCourseSection : AutobahnBase, Interfaces.IK12StudentCourseSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.GradeEarned non nullable property
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.GradeValueQualifier non nullable property
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.NumberOfCreditsAttempted nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.NumberOfCreditsEarned nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.TuitionFunded nullable property
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSection.ExitWithdrawalDate nullable property
        /// </summary>
        public System.DateTime? ExitWithdrawalDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
