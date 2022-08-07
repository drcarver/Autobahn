//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalPerformanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalPerformanceViewModel
     /// </summary>
    public partial class GoalPerformanceViewModel : ViewModelBase, Interfaces.IGoalPerformanceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalPerformance";

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the CurrentPerformanceDescription property
        private System.String _CurrentPerformanceDescription;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the Status property
        private System.String _Status;

        // member variable for the RefGoalStatusTypeId property
        private Guid? _RefGoalStatusTypeId;

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
        /// The title of the GoalPerformanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="GoalId"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        public System.String CurrentPerformanceDescription  { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        public System.String Status  { get => _Status; set => SetProperty(ref _Status, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusTypeId"/> model
        /// </summary>
        public Guid? RefGoalStatusTypeId { get => _RefGoalStatusTypeId; set => SetProperty(ref _RefGoalStatusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription;
            Date = model.Date;
            Status = model.Status;
            RefGoalStatusTypeId = model.RefGoalStatusTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
