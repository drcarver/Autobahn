//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordViewModel.cs
//* Name:       Academic Year Designator
//* Definition: The academic year for which the data apply.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The academic year for which the data apply.
     /// </summary>
    public partial class PsStudentAcademicRecordViewModel : ViewModelBase, Interfaces.IPsStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicRecord";

        // AcademicYearDesignator -- (backing property for Academic Year Designator)
        private System.String _AcademicYearDesignator;

        // AdvancedPlacementCreditsAwarded -- (backing property for Advanced Placement Credits Awarded)
        private System.Int32? _AdvancedPlacementCreditsAwarded;

        // CourseTotal -- (backing property for Course Total)
        private System.Int32? _CourseTotal;

        // CreditsAttemptedCumulative -- (backing property for Credits Attempted Cumulative)
        private System.Decimal? _CreditsAttemptedCumulative;

        // CreditsEarnedCumulative -- (backing property for Credits Earned Cumulative)
        private System.Decimal? _CreditsEarnedCumulative;

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.String _DiplomaOrCredentialAwardDate;

        // DualCreditDualEnrollmentCredits -- (backing property for Dual Credit Dual Enrollment Credits Awarded)
        private System.Decimal? _DualCreditDualEnrollmentCredits;

        // EnteringTerm -- (backing property for Postsecondary Student Entering Term)
        private System.String _EnteringTerm;

        // GradePointAverage -- (backing property for Grade Point Average)
        private System.Decimal? _GradePointAverage;

        // GradePointAverageCumulative -- (backing property for Grade Point Average Cumulative)
        private System.Decimal? _GradePointAverageCumulative;

        // NumberOfCreditsAttempted -- (backing property for Number of Credits Attempted)
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAcademicTermDesignatorId -- (backing property for Academic Term Designator)
        private Guid? _RefAcademicTermDesignatorId;

        // RefCreditHoursAppliedOtherProgramId -- (backing property for Credit Hours Applied Other Program)
        private Guid? _RefCreditHoursAppliedOtherProgramId;

        // RefProfessionalTechCredentialTypeId -- (backing property for Professional or Technical Credential Conferred)
        private Guid? _RefProfessionalTechCredentialTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Academic Year Designator
        /// <para>
        /// The academic year for which the data apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19702">Academic Year Designator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AcademicYearDesignator { get => _AcademicYearDesignator; set => SetProperty(ref _AcademicYearDesignator, value); }

        /// <summary>
        /// Advanced Placement Credits Awarded
        /// <para>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19018">Advanced Placement Credits Awarded</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        /// <summary>
        /// Course Total
        /// <para>
        /// The total number of courses listed on a transcript. Used as a check digit for integrity purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20282">Course Total</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? CourseTotal { get => _CourseTotal; set => SetProperty(ref _CourseTotal, value); }

        /// <summary>
        /// Credits Attempted Cumulative
        /// <para>
        /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// Credits Earned Cumulative
        /// <para>
        /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// Dual Credit Dual Enrollment Credits Awarded
        /// <para>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of dual credit/dual enrollment courses. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19085">Dual Credit Dual Enrollment Credits Awarded</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? DualCreditDualEnrollmentCredits { get => _DualCreditDualEnrollmentCredits; set => SetProperty(ref _DualCreditDualEnrollmentCredits, value); }

        /// <summary>
        /// Postsecondary Student Entering Term
        /// <para>
        /// The term and year of the initial enrollment of an individual in credit bearing courses or developmental/remedial courses at an institution after completing high school or a high school equivalency program (e.g., GED, Adult High School Diploma).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20396">Postsecondary Student Entering Term</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EnteringTerm { get => _EnteringTerm; set => SetProperty(ref _EnteringTerm, value); }

        /// <summary>
        /// Grade Point Average
        /// <para>
        /// The value of the total quality points divided by the Credit Hours for Grade Point Average. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19127">Grade Point Average</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? GradePointAverage { get => _GradePointAverage; set => SetProperty(ref _GradePointAverage, value); }

        /// <summary>
        /// Grade Point Average Cumulative
        /// <para>
        /// A measure of average performance in all courses taken by a person during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the person was previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19128">Grade Point Average Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

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
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Academic Term Designator
        /// <para>
        /// The academic term for which the data apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19703">Academic Term Designator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Credit Hours Applied Other Program
        /// <para>
        /// Codes identifying the set of credit hours taken in other programs or degrees that were applied to the individual's degree.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20283">Credit Hours Applied Other Program</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get => _RefCreditHoursAppliedOtherProgramId; set => SetProperty(ref _RefCreditHoursAppliedOtherProgramId, value); }

        /// <summary>
        /// Professional or Technical Credential Conferred
        /// <para>
        /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get => _RefProfessionalTechCredentialTypeId; set => SetProperty(ref _RefProfessionalTechCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicYearDesignator = model.AcademicYearDesignator; // Academic Year Designator
            AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded; // Advanced Placement Credits Awarded
            CourseTotal = model.CourseTotal; // Course Total
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // Credits Attempted Cumulative
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // Credits Earned Cumulative
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            DualCreditDualEnrollmentCredits = model.DualCreditDualEnrollmentCredits; // Dual Credit Dual Enrollment Credits Awarded
            EnteringTerm = model.EnteringTerm; // Postsecondary Student Entering Term
            GradePointAverage = model.GradePointAverage; // Grade Point Average
            GradePointAverageCumulative = model.GradePointAverageCumulative; // Grade Point Average Cumulative
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // Number of Credits Attempted
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // Academic Term Designator
            RefCreditHoursAppliedOtherProgramId = model.RefCreditHoursAppliedOtherProgramId; // Credit Hours Applied Other Program
            RefProfessionalTechCredentialTypeId = model.RefProfessionalTechCredentialTypeId; // Professional or Technical Credential Conferred
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefProfessionalTechCredentialType List
        /// <summary>
        /// The complete Academic Year Designator List
        /// </summary>
        private static List<ReferenceModelBase> RefProfessionalTechCredentialTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
