//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusionViewModel
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionViewModel : ViewModelBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherStudentDataLinkExclusion";

        // member variable for the K12StaffAssignmentId property
        private Guid _K12StaffAssignmentId;

        // member variable for the K12StudentCourseSectionId property
        private Guid _K12StudentCourseSectionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the TeacherStudentDataLinkExclusionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12StaffAssignment"/> model
        /// </summary>
        public Guid K12StaffAssignmentId { get => _K12StaffAssignmentId; set => SetProperty(ref _K12StaffAssignmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get => _K12StudentCourseSectionId; set => SetProperty(ref _K12StudentCourseSectionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherStudentDataLinkExclusion model)
        {
            IsBusy = true;
            Id = model.Id;
            K12StaffAssignmentId = model.K12StaffAssignmentId;
            K12StudentCourseSectionId = model.K12StudentCourseSectionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
