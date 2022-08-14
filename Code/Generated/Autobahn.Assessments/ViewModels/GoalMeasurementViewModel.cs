//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalMeasurementViewModel
     /// </summary>
    public partial class GoalMeasurementViewModel : ViewModelBase, Interfaces.IGoalMeasurement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurement";

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the RefGoalMeasurementTypeId property
        private Guid? _RefGoalMeasurementTypeId;

        // member variable for the Schedule property
        private System.String _Schedule;

        // member variable for the SuccessCriteria property
        private System.String _SuccessCriteria;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalMeasurementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get => _RefGoalMeasurementTypeId; set => SetProperty(ref _RefGoalMeasurementTypeId, value); }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public System.String Schedule { get => _Schedule; set => SetProperty(ref _Schedule, value); }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public System.String SuccessCriteria { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId;
            Schedule = model.Schedule;
            SuccessCriteria = model.SuccessCriteria;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
