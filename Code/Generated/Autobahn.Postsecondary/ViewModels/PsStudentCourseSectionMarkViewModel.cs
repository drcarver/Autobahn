//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _CourseNarrativeExplanationGrade;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // member variable for the StudentCourseSectionGradeNarrative property
        private  _StudentCourseSectionGradeNarrative;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CourseNarrativeExplanationGrade { get => _CourseNarrativeExplanationGrade; set => SetProperty(ref _CourseNarrativeExplanationGrade, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        /// <summary>
        /// </summary>
        public  StudentCourseSectionGradeNarrative { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // 
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
