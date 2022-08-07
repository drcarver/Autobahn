//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoalViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressGoalViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressGoal";

        // member variable for the GoalPerformanceId property
        private Guid _GoalPerformanceId;

        // member variable for the IndividualizedProgramProgressReportId property
        private Guid _IndividualizedProgramProgressReportId;

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
        /// The title of the IndividualizedProgramProgressGoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="GoalPerformanceId"/> model
        /// </summary>
        public Guid GoalPerformanceId { get => _GoalPerformanceId; set => SetProperty(ref _GoalPerformanceId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportId"/> model
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
