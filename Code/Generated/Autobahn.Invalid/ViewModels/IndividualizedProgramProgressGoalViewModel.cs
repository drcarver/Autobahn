//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressGoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressGoal";

        // member variable for the GoalPerformanceId property
        private Guid _GoalPerformanceId;

        // member variable for the IndividualizedProgramProgressReportId property
        private Guid _IndividualizedProgramProgressReportId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramProgressGoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="GoalPerformance"/> model
        /// </summary>
        public Guid GoalPerformanceId { get => _GoalPerformanceId; set => SetProperty(ref _GoalPerformanceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramProgressReport"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportId { get => _IndividualizedProgramProgressReportId; set => SetProperty(ref _IndividualizedProgramProgressReportId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalPerformanceId = model.GoalPerformanceId;
            IndividualizedProgramProgressReportId = model.IndividualizedProgramProgressReportId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
