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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseSectionAssessmentReportingMethodId property
        private Guid? _RefCourseSectionAssessmentReportingMethodId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

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
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseSectionAssessmentReportingMethodId = model.RefCourseSectionAssessmentReportingMethodId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
