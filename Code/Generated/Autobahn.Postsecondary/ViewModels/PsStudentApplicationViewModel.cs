//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentApplication View Model
     /// </summary>
    public partial class PsStudentApplicationViewModel : ViewModelBase, Interfaces.IPsStudentApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentApplication";

        // GradePointAverageCumulative -- (backing property for Grade Point Average Cumulative)
        private System.Decimal? _GradePointAverageCumulative;

        // HighSchoolGraduatingClassSize -- (backing property for Size of High School Graduating Class)
        private System.Int32? _HighSchoolGraduatingClassSize;

        // HighSchoolPercentile -- (backing property for High School Percentile)
        private System.Decimal? _HighSchoolPercentile;

        // HighSchoolStudentClassRank -- (backing property for High School Student Class Rank)
        private System.Int32? _HighSchoolStudentClassRank;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // PostsecondaryApplicant -- (backing property for Postsecondary Applicant)
        private System.Boolean? _PostsecondaryApplicant;

        // RefAdmittedStudentId -- (backing property for Admitted Student)
        private Guid? _RefAdmittedStudentId;

        // RefGpaWeightedIndicatorId -- (backing property for Grade Point Average Weighted Indicator)
        private Guid? _RefGpaWeightedIndicatorId;

        // RefGradePointAverageDomainId -- (backing property for Grade Point Average Domain)
        private Guid? _RefGradePointAverageDomainId;

        // WaitListedStudent -- (backing property for Wait Listed Student)
        private System.Boolean? _WaitListedStudent;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

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
        /// Size of High School Graduating Class
        /// <para>
        /// The total number of students in the student's high school graduating class.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19294">Size of High School Graduating Class</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? HighSchoolGraduatingClassSize { get => _HighSchoolGraduatingClassSize; set => SetProperty(ref _HighSchoolGraduatingClassSize, value); }

        /// <summary>
        /// High School Percentile
        /// <para>
        /// The High School Rank divided by the Size of High School Graduating Class expressed as a percentage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19740">High School Percentile</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? HighSchoolPercentile { get => _HighSchoolPercentile; set => SetProperty(ref _HighSchoolPercentile, value); }

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
        /// Postsecondary Applicant
        /// <para>
        /// An individual who has fulfilled the institution's requirements to be considered for admission (including payment or waiving of the application fee, if any) and who has been notified of one of the following actions: admission, nonadmission, placement on waiting list, or application withdrawn (by applicant or institution). Include early decision, early action, and students who began studies during summer in this cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19735">Postsecondary Applicant</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PostsecondaryApplicant { get => _PostsecondaryApplicant; set => SetProperty(ref _PostsecondaryApplicant, value); }

        /// <summary>
        /// Admitted Student
        /// <para>
        /// Applicant who has been granted an official offer to enroll in a postsecondary institution. Admitted applicants should include wait-listed students who were subsequently offered admission.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19736">Admitted Student</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdmittedStudentId { get => _RefAdmittedStudentId; set => SetProperty(ref _RefAdmittedStudentId, value); }

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
        /// Grade Point Average Domain
        /// <para>
        /// The domain to which the Grade Point Average is referencing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19739">Grade Point Average Domain</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get => _RefGradePointAverageDomainId; set => SetProperty(ref _RefGradePointAverageDomainId, value); }

        /// <summary>
        /// Wait Listed Student
        /// <para>
        /// A person who meets the admission requirements but will only be offered a place in the class if space becomes available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19738">Wait Listed Student</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? WaitListedStudent { get => _WaitListedStudent; set => SetProperty(ref _WaitListedStudent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            GradePointAverageCumulative = model.GradePointAverageCumulative; // Grade Point Average Cumulative
            HighSchoolGraduatingClassSize = model.HighSchoolGraduatingClassSize; // Size of High School Graduating Class
            HighSchoolPercentile = model.HighSchoolPercentile; // High School Percentile
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // High School Student Class Rank
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            PostsecondaryApplicant = model.PostsecondaryApplicant; // Postsecondary Applicant
            RefAdmittedStudentId = model.RefAdmittedStudentId; // Admitted Student
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // Grade Point Average Weighted Indicator
            RefGradePointAverageDomainId = model.RefGradePointAverageDomainId; // Grade Point Average Domain
            WaitListedStudent = model.WaitListedStudent; // Wait Listed Student
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
