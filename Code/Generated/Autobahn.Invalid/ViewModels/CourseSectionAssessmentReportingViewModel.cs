//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionAssessmentReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionAssessmentReportingViewModel
     /// </summary>
    public partial class CourseSectionAssessmentReportingViewModel : ViewModelBase, Interfaces.ICourseSectionAssessmentReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionAssessmentReporting";

        // member variable for the RefCourseSectionAssessmentReportingMethodId property
        private Guid? _RefCourseSectionAssessmentReportingMethodId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionAssessmentReportingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionAssessmentReportingMethod"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Section Assessment Reporting Method")]
        public Guid? RefCourseSectionAssessmentReportingMethodId { get => _RefCourseSectionAssessmentReportingMethodId; set => SetProperty(ref _RefCourseSectionAssessmentReportingMethodId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionAssessmentReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCourseSectionAssessmentReportingMethodId = model.RefCourseSectionAssessmentReportingMethodId; // Course Section Assessment Reporting Method
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
