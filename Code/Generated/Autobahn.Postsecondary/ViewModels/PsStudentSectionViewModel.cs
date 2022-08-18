//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionViewModel.cs
//* Name:       Course Academic Grade
//* Definition: The final grade awarded for participation in the course. 
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The final grade awarded for participation in the course. 
     /// </summary>
    public partial class PsStudentSectionViewModel : ViewModelBase, Interfaces.IPsStudentSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentSection";

        // AcademicGrade -- (backing property for Course Academic Grade)
        private System.String _AcademicGrade;

        // CourseOverrideSchool -- (backing property for Course Override School)
        private System.String _CourseOverrideSchool;

        // DegreeApplicability -- (backing property for Degree Applicability)
        private System.Boolean? _DegreeApplicability;

        // NumberOfCreditsAttempted -- (backing property for Number of Credits Attempted)
        private System.Decimal? _NumberOfCreditsAttempted;

        // NumberOfCreditsEarned -- (backing property for Number of Credits Earned)
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // QualityPointsEarned -- (backing property for Course Quality Points Earned)
        private System.Decimal? _QualityPointsEarned;

        // RefCourseAcademicGradeStatusCodeId -- (backing property for Course Academic Grade Status Code)
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // RefCourseRepeatCodeId -- (backing property for Course Repeat Code)
        private Guid? _RefCourseRepeatCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Academic Grade
        /// <para>
        /// The final grade awarded for participation in the course. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AcademicGrade { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        /// <summary>
        /// Course Override School
        /// <para>
        /// The school where the credit was earned if different from the institution reporting. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19063">Course Override School</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseOverrideSchool { get => _CourseOverrideSchool; set => SetProperty(ref _CourseOverrideSchool, value); }

        /// <summary>
        /// Degree Applicability
        /// <para>
        /// An indication that the course is a part of a degree program. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19077">Degree Applicability</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DegreeApplicability { get => _DegreeApplicability; set => SetProperty(ref _DegreeApplicability, value); }

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
        /// Course Quality Points Earned
        /// <para>
        /// The numerical value assigned to a letter grade to provide a basis of quantitative determination of an average. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19064">Course Quality Points Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? QualityPointsEarned { get => _QualityPointsEarned; set => SetProperty(ref _QualityPointsEarned, value); }

        /// <summary>
        /// Course Academic Grade Status Code
        /// <para>
        /// Additional information regarding the context of the given grade.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

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

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicGrade = model.AcademicGrade; // Course Academic Grade
            CourseOverrideSchool = model.CourseOverrideSchool; // Course Override School
            DegreeApplicability = model.DegreeApplicability; // Degree Applicability
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // Number of Credits Attempted
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // Number of Credits Earned
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            QualityPointsEarned = model.QualityPointsEarned; // Course Quality Points Earned
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // Course Academic Grade Status Code
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // Course Repeat Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
