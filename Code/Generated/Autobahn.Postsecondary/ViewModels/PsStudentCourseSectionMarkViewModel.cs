//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkViewModel.cs
//* Name:       Course Narrative Explanation Grade
//* Definition: The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
     /// </summary>
    public partial class PsStudentCourseSectionMarkViewModel : ViewModelBase, Interfaces.IPsStudentCourseSectionMark
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentCourseSectionMark";

        // CourseNarrativeExplanationGrade -- (backing property for Course Narrative Explanation Grade)
        private System.String _CourseNarrativeExplanationGrade;

        // member variable for the PsStudentSectionId property
        private Guid _PsStudentSectionId;

        // RefCourseAcademicGradeStatusCodeId -- (backing property for Course Academic Grade Status Code)
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // StudentCourseSectionGradeNarrative -- (backing property for Student Course Section Grade Narrative)
        private System.String _StudentCourseSectionGradeNarrative;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Narrative Explanation Grade
        /// <para>
        /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20279">Course Narrative Explanation Grade</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseNarrativeExplanationGrade { get => _CourseNarrativeExplanationGrade; set => SetProperty(ref _CourseNarrativeExplanationGrade, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsStudentSection"/> model
        /// </summary>
        public Guid PsStudentSectionId { get => _PsStudentSectionId; set => SetProperty(ref _PsStudentSectionId, value); }

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
        /// Student Course Section Grade Narrative
        /// <para>
        /// The narrative of the student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade; // Course Narrative Explanation Grade
            PsStudentSectionId = model.PsStudentSectionId; // 
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // Course Academic Grade Status Code
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // Student Course Section Grade Narrative
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
