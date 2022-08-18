//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionModel.cs
//***************************************************************************

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
        /// Course Section Exit Withdrawal Date
        /// <para>
        /// The year, month and day of the first day after the date of a person's last enrollment in a course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19653">Course Section Exit Withdrawal Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ExitWithdrawalDate { get; set; }

        /// <summary>
        /// Student Course Section Grade Earned
        /// <para>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19124">Student Course Section Grade Earned</a>
        /// </para>
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// Grade Value Qualifier
        /// <para>
        /// The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student's Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19609">Grade Value Qualifier</a>
        /// </para>
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Number of Credits Attempted
        /// <para>
        /// The number of credits that a student can earn for enrolling in and completing a given course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Number of Credits Earned
        /// <para>
        /// The number of credits an individual earns by the successful completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Tuition Funded
        /// <para>
        /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
        /// </para>
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

    }
}
