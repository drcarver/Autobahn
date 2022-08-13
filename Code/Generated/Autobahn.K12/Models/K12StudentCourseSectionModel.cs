//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSection Model
     /// </summary>
    public partial class K12StudentCourseSectionModel : AutobahnBase, Interfaces.IK12StudentCourseSection
    {
        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.DateTime? ExitWithdrawalDate { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

    }
}
