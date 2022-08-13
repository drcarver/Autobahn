//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   GoalPerformanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The GoalPerformanceViewModel
     /// </summary>
    public partial class GoalPerformanceViewModel : ViewModelBase, Interfaces.IGoalPerformance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalPerformance";

        // member variable for the CurrentPerformanceDescription property
        private System.String _CurrentPerformanceDescription;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the RefGoalStatusTypeId property
        private Guid? _RefGoalStatusTypeId;

        // member variable for the Status property
        private System.String _Status;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalPerformanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </summary>
        public System.String CurrentPerformanceDescription { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </summary>
        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusType"/> model
        /// </summary>
        public Guid? RefGoalStatusTypeId { get => _RefGoalStatusTypeId; set => SetProperty(ref _RefGoalStatusTypeId, value); }

        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </summary>
        public System.String Status { get => _Status; set => SetProperty(ref _Status, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription;
            Date = model.Date;
            GoalId = model.GoalId;
            RefGoalStatusTypeId = model.RefGoalStatusTypeId;
            Status = model.Status;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
