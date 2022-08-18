//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionAssessmentReportingViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionAssessmentReporting View Model
     /// </summary>
    public partial class CourseSectionAssessmentReportingViewModel : ViewModelBase, Interfaces.ICourseSectionAssessmentReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionAssessmentReporting";

        // member variable for the CourseSectionId property
        private Guid? _CourseSectionId;

        // RefCourseSectionAssessmentReportingMethodId -- (backing property for Course Section Assessment Reporting Method)
        private Guid? _RefCourseSectionAssessmentReportingMethodId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Course Section Assessment Reporting Method
        /// <para>
        /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
        /// </para>
        /// </summary>
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
            CourseSectionId = model.CourseSectionId; // 
            RefCourseSectionAssessmentReportingMethodId = model.RefCourseSectionAssessmentReportingMethodId; // Course Section Assessment Reporting Method
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
