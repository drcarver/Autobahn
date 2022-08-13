//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResult_PerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentResult_PerformanceLevelViewModel : ViewModelBase, Interfaces.IAssessmentResult_PerformanceLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult_PerformanceLevel";

        // member variable for the AssessmentPerformanceLevelId property
        private Guid _AssessmentPerformanceLevelId;

        // member variable for the AssessmentResultId property
        private Guid _AssessmentResultId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResult_PerformanceLevelViewModel
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
        public void Load(Interfaces.IAssessmentResult_PerformanceLevel model)
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
