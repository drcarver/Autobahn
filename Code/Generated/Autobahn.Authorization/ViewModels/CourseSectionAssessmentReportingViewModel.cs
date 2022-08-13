//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CourseSectionAssessmentReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The CourseSectionAssessmentReportingViewModel
     /// </summary>
    public partial class CourseSectionAssessmentReportingViewModel : ViewModelBase, Interfaces.ICourseSectionAssessmentReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionAssessmentReporting";

        // member variable for the CourseSectionId property
        private Guid? _CourseSectionId;

        // member variable for the RefCourseSectionAssessmentReportingMethodId property
        private Guid? _RefCourseSectionAssessmentReportingMethodId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionAssessmentReportingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionAssessmentReportingMethod"/> model
        /// </summary>
        public Guid? RefCourseSectionAssessmentReportingMethodId { get => _RefCourseSectionAssessmentReportingMethodId; set => SetProperty(ref _RefCourseSectionAssessmentReportingMethodId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionAssessmentReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            RefCourseSectionAssessmentReportingMethodId = model.RefCourseSectionAssessmentReportingMethodId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
