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

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentCourseSectionMarkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Academic Grade Status Code")]
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // Course Academic Grade Status Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
