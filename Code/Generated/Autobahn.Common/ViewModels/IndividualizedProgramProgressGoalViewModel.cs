//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressGoalViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal View Model
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
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoalPerformance"/> model
        /// </summary>
        public Guid GoalPerformanceId { get => _GoalPerformanceId; set => SetProperty(ref _GoalPerformanceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
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
            GoalPerformanceId = model.GoalPerformanceId; // 
            IndividualizedProgramProgressReportId = model.IndividualizedProgramProgressReportId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
