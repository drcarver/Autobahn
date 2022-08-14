//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentCourseSectionMarkViewModel
     /// </summary>
    public partial class PsStudentCourseSectionMarkViewModel : ViewModelBase, Interfaces.IPsStudentCourseSectionMark
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentCourseSectionMark";

        // member variable for the CourseNarrativeExplanationGrade property
        private System.String _CourseNarrativeExplanationGrade;

        // member variable for the PsStudentSectionId property
        private Guid _PsStudentSectionId;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // member variable for the StudentCourseSectionGradeNarrative property
        private System.String _StudentCourseSectionGradeNarrative;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentCourseSectionMarkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Additional information regarding the context of the given grade.
        /// </summary>
        public System.String CourseNarrativeExplanationGrade { get => _CourseNarrativeExplanationGrade; set => SetProperty(ref _CourseNarrativeExplanationGrade, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsStudentSection"/> model
        /// </summary>
        public Guid PsStudentSectionId { get => _PsStudentSectionId; set => SetProperty(ref _PsStudentSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        /// <summary>
        /// Additional information regarding the context of the given grade.
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
            CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade;
            PsStudentSectionId = model.PsStudentSectionId;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
