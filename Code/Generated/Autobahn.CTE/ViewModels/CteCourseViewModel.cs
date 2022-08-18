//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteCourseViewModel.cs
//* Name:       Available Carnegie Unit Credit
//* Definition: Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
     /// </summary>
    public partial class CteCourseViewModel : ViewModelBase, Interfaces.ICteCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CteCourse";

        // AvailableCarnegieUnitCredit -- (backing property for Available Carnegie Unit Credit)
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // CoreAcademicCourse -- (backing property for Core Academic Course)
        private System.Boolean? _CoreAcademicCourse;

        // CourseAlignedWithStandards -- (backing property for Course Aligned with Standards)
        private System.Boolean? _CourseAlignedWithStandards;

        // CourseDepartmentName -- (backing property for Course Department Name)
        private System.String _CourseDepartmentName;

        // member variable for the CourseId property
        private Guid _CourseId;

        // HighSchoolCourseRequirement -- (backing property for High School Course Requirement)
        private System.Boolean? _HighSchoolCourseRequirement;

        // RefAdditionalCreditTypeId -- (backing property for Additional Credit Type)
        private Guid? _RefAdditionalCreditTypeId;

        // RefCareerClusterId -- (backing property for Career Cluster)
        private Guid? _RefCareerClusterId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // RefCreditTypeEarnedId -- (backing property for Credit Unit Type)
        private Guid? _RefCreditTypeEarnedId;

        // RefCurriculumFrameworkTypeId -- (backing property for Curriculum Framework Type)
        private Guid? _RefCurriculumFrameworkTypeId;

        // RefSCEDCourseLevelId -- (backing property for School Courses for the Exchange of Data Course Level)
        private Guid? _RefSCEDCourseLevelId;

        // RefSCEDCourseSubjectAreaId -- (backing property for School Courses for the Exchange of Data Course Subject Area)
        private Guid? _RefSCEDCourseSubjectAreaId;

        // SCEDCourseCode -- (backing property for School Courses for the Exchange of Data Course Code)
        private System.String _SCEDCourseCode;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        /// <summary>
        /// Core Academic Course
        /// <para>
        /// The course meets the state definition of a core academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CoreAcademicCourse { get => _CoreAcademicCourse; set => SetProperty(ref _CoreAcademicCourse, value); }

        /// <summary>
        /// Course Aligned with Standards
        /// <para>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CourseAlignedWithStandards { get => _CourseAlignedWithStandards; set => SetProperty(ref _CourseAlignedWithStandards, value); }

        /// <summary>
        /// Course Department Name
        /// <para>
        /// Department with jurisdiction over this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20525">Course Department Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseDepartmentName { get => _CourseDepartmentName; set => SetProperty(ref _CourseDepartmentName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// High School Course Requirement
        /// <para>
        /// An indication that this course credit is required for a high school diploma.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19137">High School Course Requirement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? HighSchoolCourseRequirement { get => _HighSchoolCourseRequirement; set => SetProperty(ref _HighSchoolCourseRequirement, value); }

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
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

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
        /// Curriculum Framework Type
        /// <para>
        /// An indication of the standard curriculum used for this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get => _RefCurriculumFrameworkTypeId; set => SetProperty(ref _RefCurriculumFrameworkTypeId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Level
        /// <para>
        ///  The course's level of rigor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20488">School Courses for the Exchange of Data Course Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get => _RefSCEDCourseLevelId; set => SetProperty(ref _RefSCEDCourseLevelId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Subject Area
        /// <para>
        /// The intended major subject area of the education course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20491">School Courses for the Exchange of Data Course Subject Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Code
        /// <para>
        /// The five-digit SCED code. The first two-digits of the code represent the Course Subject Area and the next three digits identify the course number. These identifiers are fairly general but provide enough specificity to identify the course's topic and to distinguish it from other courses in that subject area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20490">School Courses for the Exchange of Data Course Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SCEDCourseCode { get => _SCEDCourseCode; set => SetProperty(ref _SCEDCourseCode, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICteCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // Available Carnegie Unit Credit
            CoreAcademicCourse = model.CoreAcademicCourse; // Core Academic Course
            CourseAlignedWithStandards = model.CourseAlignedWithStandards; // Course Aligned with Standards
            CourseDepartmentName = model.CourseDepartmentName; // Course Department Name
            CourseId = model.CourseId; // 
            HighSchoolCourseRequirement = model.HighSchoolCourseRequirement; // High School Course Requirement
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
            RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId; // 
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // Credit Unit Type
            RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId; // Curriculum Framework Type
            RefSCEDCourseLevelId = model.RefSCEDCourseLevelId; // School Courses for the Exchange of Data Course Level
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // School Courses for the Exchange of Data Course Subject Area
            SCEDCourseCode = model.SCEDCourseCode; // School Courses for the Exchange of Data Course Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
