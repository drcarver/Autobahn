//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCourseSectionMarkViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentCourseSectionMarkViewModel
     /// </summary>
    public partial class PsStudentCourseSectionMarkViewModel : BindableBase, IPsStudentCourseSectionMark
    {
#region "Backing Fields"
        // member variable for the CourseNarrativeExplanationGrade property
        private System.String _CourseNarrativeExplanationGrade;

        // member variable for the StudentCourseSectionGradeNarrative property
        private System.String _StudentCourseSectionGradeNarrative;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PsStudentSectionId"/> model
        /// </summary>
        public Guid PsStudentSectionId { get; set; }

        public System.String CourseNarrativeExplanationGrade  { get => _CourseNarrativeExplanationGrade; set => SetProperty(ref _CourseNarrativeExplanationGrade, value); }

        public System.String StudentCourseSectionGradeNarrative  { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCodeId"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPsStudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            PsStudentSectionId = model.PsStudentSectionId;
            CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade;
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
