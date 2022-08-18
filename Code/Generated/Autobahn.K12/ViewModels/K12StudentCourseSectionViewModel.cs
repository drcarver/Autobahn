//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSection View Model
     /// </summary>
    public partial class K12StudentCourseSectionViewModel : ViewModelBase, Interfaces.IK12StudentCourseSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSection";

        // ExitWithdrawalDate -- (backing property for Course Section Exit Withdrawal Date)
        private System.DateTime? _ExitWithdrawalDate;

        // GradeEarned -- (backing property for Student Course Section Grade Earned)
        private System.String _GradeEarned;

        // GradeValueQualifier -- (backing property for Grade Value Qualifier)
        private System.String _GradeValueQualifier;

        // NumberOfCreditsAttempted -- (backing property for Number of Credits Attempted)
        private System.Decimal? _NumberOfCreditsAttempted;

        // NumberOfCreditsEarned -- (backing property for Number of Credits Earned)
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAdditionalCreditTypeId -- (backing property for Additional Credit Type)
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // RefCourseRepeatCodeId -- (backing property for Course Repeat Code)
        private Guid? _RefCourseRepeatCodeId;

        // RefCourseSectionEnrollmentStatusTypeId -- (backing property for Course Section Enrollment Status Type)
        private Guid? _RefCourseSectionEnrollmentStatusTypeId;

        // RefCourseSectionEntryTypeId -- (backing property for Course Section Entry Type)
        private Guid? _RefCourseSectionEntryTypeId;

        // RefCourseSectionExitTypeId -- (backing property for Course Section Exit Type)
        private Guid? _RefCourseSectionExitTypeId;

        // RefCreditTypeEarnedId -- (backing property for Credit Unit Type)
        private Guid? _RefCreditTypeEarnedId;

        // RefExitOrWithdrawalStatusId -- (backing property for Exit or Withdrawal Status)
        private Guid? _RefExitOrWithdrawalStatusId;

        // RefGradeLevelWhenCourseTakenId -- (backing property for Grade Level When Course Taken)
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // RefPreAndPostTestIndicatorId -- (backing property for Pre and Post Test Indicator)
        private Guid? _RefPreAndPostTestIndicatorId;

        // RefProgressLevelId -- (backing property for Progress Level)
        private Guid? _RefProgressLevelId;

        // TuitionFunded -- (backing property for Tuition Funded)
        private System.Boolean? _TuitionFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Section Exit Withdrawal Date
        /// <para>
        /// The year, month and day of the first day after the date of a person's last enrollment in a course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19653">Course Section Exit Withdrawal Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ExitWithdrawalDate { get => _ExitWithdrawalDate; set => SetProperty(ref _ExitWithdrawalDate, value); }

        /// <summary>
        /// Student Course Section Grade Earned
        /// <para>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19124">Student Course Section Grade Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        /// <summary>
        /// Grade Value Qualifier
        /// <para>
        /// The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student's Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19609">Grade Value Qualifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// Number of Credits Attempted
        /// <para>
        /// The number of credits that a student can earn for enrolling in and completing a given course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// Number of Credits Earned
        /// <para>
        /// The number of credits an individual earns by the successful completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Additional Credit Type
        /// <para>
        /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Course Repeat Code
        /// <para>
        /// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19065">Course Repeat Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        /// <summary>
        /// Course Section Enrollment Status Type
        /// <para>
        /// The status related to a student enrollment in an instance of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19977">Course Section Enrollment Status Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseSectionEnrollmentStatusTypeId { get => _RefCourseSectionEnrollmentStatusTypeId; set => SetProperty(ref _RefCourseSectionEnrollmentStatusTypeId, value); }

        /// <summary>
        /// Course Section Entry Type
        /// <para>
        /// The process by which a student enters a school (Course Section) during a given academic session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19652">Course Section Entry Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseSectionEntryTypeId { get => _RefCourseSectionEntryTypeId; set => SetProperty(ref _RefCourseSectionEntryTypeId, value); }

        /// <summary>
        /// Course Section Exit Type
        /// <para>
        /// The circumstances under which the student exited from membership in a course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19654">Course Section Exit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseSectionExitTypeId { get => _RefCourseSectionExitTypeId; set => SetProperty(ref _RefCourseSectionExitTypeId, value); }

        /// <summary>
        /// Credit Unit Type
        /// <para>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19072">Credit Unit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Exit or Withdrawal Status
        /// <para>
        /// An indication as to whether an instance of student exit/withdrawal is considered to be of a permanent or temporary nature.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19108">Exit or Withdrawal Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Grade Level When Course Taken
        /// <para>
        /// Student's grade level at time of course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19125">Grade Level When Course Taken</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Pre and Post Test Indicator
        /// <para>
        /// An indication of whether students took both a pre-test and a post-test to measure academic improvement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19563">Pre and Post Test Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Progress Level
        /// <para>
        /// The amount of progress shown in academic subjects.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19553">Progress Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        /// <summary>
        /// Tuition Funded
        /// <para>
        /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            ExitWithdrawalDate = model.ExitWithdrawalDate; // Course Section Exit Withdrawal Date
            GradeEarned = model.GradeEarned; // Student Course Section Grade Earned
            GradeValueQualifier = model.GradeValueQualifier; // Grade Value Qualifier
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // Number of Credits Attempted
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // Number of Credits Earned
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId; // 
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // Course Repeat Code
            RefCourseSectionEnrollmentStatusTypeId = model.RefCourseSectionEnrollmentStatusTypeId; // Course Section Enrollment Status Type
            RefCourseSectionEntryTypeId = model.RefCourseSectionEntryTypeId; // Course Section Entry Type
            RefCourseSectionExitTypeId = model.RefCourseSectionExitTypeId; // Course Section Exit Type
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // Credit Unit Type
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // Exit or Withdrawal Status
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // Grade Level When Course Taken
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // Pre and Post Test Indicator
            RefProgressLevelId = model.RefProgressLevelId; // Progress Level
            TuitionFunded = model.TuitionFunded; // Tuition Funded
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
