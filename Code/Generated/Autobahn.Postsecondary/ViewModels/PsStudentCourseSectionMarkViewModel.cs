//**********************************************************
//* DomainName: Autobahn.Postsecondary
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

        // member variable for the PsStudentSectionId property
        private Guid _PsStudentSectionId;

        // member variable for the CourseNarrativeExplanationGrade property
        private System.String _CourseNarrativeExplanationGrade;

        // member variable for the StudentCourseSectionGradeNarrative property
        private System.String _StudentCourseSectionGradeNarrative;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentCourseSectionMarkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PsStudentSectionId"/> model
        /// </summary>
        public Guid PsStudentSectionId { get => _PsStudentSectionId; set => SetProperty(ref _PsStudentSectionId, value); }

        public System.String CourseNarrativeExplanationGrade  { get => _CourseNarrativeExplanationGrade; set => SetProperty(ref _CourseNarrativeExplanationGrade, value); }

        public System.String StudentCourseSectionGradeNarrative  { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCodeId"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            PsStudentSectionId = model.PsStudentSectionId;
            CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade;
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
