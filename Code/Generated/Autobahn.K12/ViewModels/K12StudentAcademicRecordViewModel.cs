//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicRecordViewModel.cs
//* Name:       Class Ranking Date
//* Definition: The date class ranking was determined.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The date class ranking was determined.
     /// </summary>
    public partial class K12StudentAcademicRecordViewModel : ViewModelBase, Interfaces.IK12StudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicRecord";

        // ClassRankingDate -- (backing property for Class Ranking Date)
        private System.DateTime? _ClassRankingDate;

        // CreditsAttemptedCumulative -- (backing property for Credits Attempted Cumulative)
        private System.Decimal? _CreditsAttemptedCumulative;

        // CreditsEarnedCumulative -- (backing property for Credits Earned Cumulative)
        private System.Decimal? _CreditsEarnedCumulative;

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.DateTime? _DiplomaOrCredentialAwardDate;

        // GradePointAverageCumulative -- (backing property for Grade Point Average Cumulative)
        private System.Decimal? _GradePointAverageCumulative;

        // GradePointsEarnedCumulative -- (backing property for Grade Points Earned Cumulative)
        private System.Decimal? _GradePointsEarnedCumulative;

        // HighSchoolStudentClassRank -- (backing property for High School Student Class Rank)
        private System.Int32? _HighSchoolStudentClassRank;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // ProjectedGraduationDate -- (backing property for Projected Graduation Date)
        private System.DateTime? _ProjectedGraduationDate;

        // RefGpaWeightedIndicatorId -- (backing property for Grade Point Average Weighted Indicator)
        private Guid? _RefGpaWeightedIndicatorId;

        // RefHighSchoolDiplomaDistinctionTypeId -- (backing property for High School Diploma Distinction Type)
        private Guid? _RefHighSchoolDiplomaDistinctionTypeId;

        // RefHighSchoolDiplomaTypeId -- (backing property for High School Diploma Type)
        private Guid? _RefHighSchoolDiplomaTypeId;

        // RefPreAndPostTestIndicatorId -- (backing property for Pre and Post Test Indicator)
        private Guid? _RefPreAndPostTestIndicatorId;

        // RefProfessionalTechnicalCredentialTypeId -- (backing property for Professional or Technical Credential Conferred)
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

        // RefProgressLevelId -- (backing property for Progress Level)
        private Guid? _RefProgressLevelId;

        // RefPsEnrollmentActionId -- (backing property for Postsecondary Enrollment Action)
        private Guid? _RefPsEnrollmentActionId;

        // RefTechnologyLiteracyStatusId -- (backing property for Technology Literacy Status in 8th Grade)
        private Guid? _RefTechnologyLiteracyStatusId;

        // TotalNumberInClass -- (backing property for Size of High School Graduating Class)
        private System.Int32? _TotalNumberInClass;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Class Ranking Date
        /// <para>
        /// The date class ranking was determined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19042">Class Ranking Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ClassRankingDate { get => _ClassRankingDate; set => SetProperty(ref _ClassRankingDate, value); }

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
        public System.DateTime? DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

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
        /// Grade Points Earned Cumulative
        /// <para>
        /// The cumulative number of grade points a person earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19130">Grade Points Earned Cumulative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? GradePointsEarnedCumulative { get => _GradePointsEarnedCumulative; set => SetProperty(ref _GradePointsEarnedCumulative, value); }

        /// <summary>
        /// High School Student Class Rank
        /// <para>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19041">High School Student Class Rank</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Projected Graduation Date
        /// <para>
        /// The year and month the student is projected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19226">Projected Graduation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ProjectedGraduationDate { get => _ProjectedGraduationDate; set => SetProperty(ref _ProjectedGraduationDate, value); }

        /// <summary>
        /// Grade Point Average Weighted Indicator
        /// <para>
        /// An indication of whether the reported Grade Point Average is weighted or unweighted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19123">Grade Point Average Weighted Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get => _RefGpaWeightedIndicatorId; set => SetProperty(ref _RefGpaWeightedIndicatorId, value); }

        /// <summary>
        /// High School Diploma Distinction Type
        /// <para>
        /// The distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19689">High School Diploma Distinction Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get => _RefHighSchoolDiplomaDistinctionTypeId; set => SetProperty(ref _RefHighSchoolDiplomaDistinctionTypeId, value); }

        /// <summary>
        /// High School Diploma Type
        /// <para>
        /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get => _RefHighSchoolDiplomaTypeId; set => SetProperty(ref _RefHighSchoolDiplomaTypeId, value); }

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
        /// Professional or Technical Credential Conferred
        /// <para>
        /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

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
        /// Postsecondary Enrollment Action
        /// <para>
        /// The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19579">Postsecondary Enrollment Action</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get => _RefPsEnrollmentActionId; set => SetProperty(ref _RefPsEnrollmentActionId, value); }

        /// <summary>
        /// Technology Literacy Status in 8th Grade
        /// <para>
        /// An indication of the technology literacy of 8th graders.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19558">Technology Literacy Status in 8th Grade</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get => _RefTechnologyLiteracyStatusId; set => SetProperty(ref _RefTechnologyLiteracyStatusId, value); }

        /// <summary>
        /// Size of High School Graduating Class
        /// <para>
        /// The total number of students in the student's high school graduating class.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19294">Size of High School Graduating Class</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? TotalNumberInClass { get => _TotalNumberInClass; set => SetProperty(ref _TotalNumberInClass, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassRankingDate = model.ClassRankingDate; // Class Ranking Date
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // Credits Attempted Cumulative
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // Credits Earned Cumulative
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            GradePointAverageCumulative = model.GradePointAverageCumulative; // Grade Point Average Cumulative
            GradePointsEarnedCumulative = model.GradePointsEarnedCumulative; // Grade Points Earned Cumulative
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // High School Student Class Rank
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            ProjectedGraduationDate = model.ProjectedGraduationDate; // Projected Graduation Date
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // Grade Point Average Weighted Indicator
            RefHighSchoolDiplomaDistinctionTypeId = model.RefHighSchoolDiplomaDistinctionTypeId; // High School Diploma Distinction Type
            RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // High School Diploma Type
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // Pre and Post Test Indicator
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
            RefProgressLevelId = model.RefProgressLevelId; // Progress Level
            RefPsEnrollmentActionId = model.RefPsEnrollmentActionId; // Postsecondary Enrollment Action
            RefTechnologyLiteracyStatusId = model.RefTechnologyLiteracyStatusId; // Technology Literacy Status in 8th Grade
            TotalNumberInClass = model.TotalNumberInClass; // Size of High School Graduating Class
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPreAndPostTestIndicator List
        /// <summary>
        /// The complete Class Ranking Date List
        /// </summary>
        private static List<ReferenceModelBase> RefPreAndPostTestIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1d9eac84-b6ce-46a7-b9d9-32a3bdf185e2"), Code="PreAndPostTest", Description="The student took both a pre-test and post-test", Definition="The student took both a pre-test and post-test.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("5e6c9497-5a54-4b42-9d30-3a9cb75a3fb9"), Code="DidNotTakeBoth", Description="The student did not take both a pre-test and a post-test", Definition="The student did not take both a pre-test and a post-test.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProgressLevel List
        /// <summary>
        /// The complete Class Ranking Date List
        /// </summary>
        private static List<ReferenceModelBase> RefProgressLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ccd79d6e-cd27-4eeb-84ba-acefa67cbd15"), Code="NEGGRADE", Description="Negative grade level change", Definition="The students showed a negative grade level change from the pre- to post- test", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("754bcc73-f4ac-4fb5-9956-8a434d40cefb"), Code="NOCHANGE", Description="No change", Definition="The students showed no change from the pre- to post- test", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("79e2862c-9422-4858-878d-fb28c8bf6946"), Code="UPHALFGRADE", Description="Improvement of up to one half grade level", Definition="The students showed improvement of up to one half grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8bfa1080-390b-4ab9-a9eb-ded9848f8190"), Code="UPONEGRADE", Description="Improvement from one half grade level up to one full grade level", Definition="The students showed improvement from one half grade level up to one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ab18c39d-49ba-4ed4-9dea-18b6c73e1fc0"), Code="UPGTONE", Description="Improvement of more than one full grade level", Definition="The students showed improvement of more than one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefTechnologyLiteracyStatus List
        /// <summary>
        /// The complete Class Ranking Date List
        /// </summary>
        private static List<ReferenceModelBase> RefTechnologyLiteracyStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("910d257d-462b-40a0-9dde-d89d30efa4ed"), Code="TechnologyLiterate", Description="Technology literate", Definition="Technology literate is the technology literacy of person(s) in 8th grade.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c74d9041-9d12-4c74-9c62-2dc98ee4ff59"), Code="NotTechnologyLiterate", Description="Not technology literate", Definition="Not technology literate is the technology literacy of person(s) in 8th grade.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion
    }
}
