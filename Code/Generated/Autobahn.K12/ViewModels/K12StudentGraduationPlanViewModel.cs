//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentGraduationPlanViewModel
     /// </summary>
    public partial class K12StudentGraduationPlanViewModel : ViewModelBase, Interfaces.IK12StudentGraduationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentGraduationPlan";

        // member variable for the CreditsRequired property
        private System.Decimal? _CreditsRequired;

        // member variable for the K12CourseId property
        private Guid _K12CourseId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private Guid? _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentGraduationPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        public System.Decimal? CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12Course"/> model
        /// </summary>
        public Guid K12CourseId { get => _K12CourseId; set => SetProperty(ref _K12CourseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentGraduationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsRequired = model.CreditsRequired;
            K12CourseId = model.K12CourseId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId;
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
