//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResult_PerformanceLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevelViewModel
     /// </summary>
    public partial class AssessmentResult_PerformanceLevelViewModel : ViewModelBase, Interfaces.IAssessmentResult_PerformanceLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult_PerformanceLevel";

        // member variable for the AssessmentResultId property
        private Guid _AssessmentResultId;

        // member variable for the AssessmentPerformanceLevelId property
        private Guid _AssessmentPerformanceLevelId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResult_PerformanceLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResultId"/> model
        /// </summary>
        public Guid AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevelId"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get => _AssessmentPerformanceLevelId; set => SetProperty(ref _AssessmentPerformanceLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResult_PerformanceLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentResultId = model.AssessmentResultId;
            AssessmentPerformanceLevelId = model.AssessmentPerformanceLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
