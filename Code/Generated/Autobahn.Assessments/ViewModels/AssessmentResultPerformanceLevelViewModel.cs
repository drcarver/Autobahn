//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentResultPerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentResultPerformanceLevelViewModel : ViewModelBase, Interfaces.IAssessmentResultPerformanceLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResultPerformanceLevel";

        // member variable for the AssessmentPerformanceLevelId property
        private Guid _AssessmentPerformanceLevelId;

        // member variable for the AssessmentResultId property
        private Guid _AssessmentResultId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResultPerformanceLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get => _AssessmentPerformanceLevelId; set => SetProperty(ref _AssessmentPerformanceLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResultPerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPerformanceLevelId = model.AssessmentPerformanceLevelId;
            AssessmentResultId = model.AssessmentResultId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
