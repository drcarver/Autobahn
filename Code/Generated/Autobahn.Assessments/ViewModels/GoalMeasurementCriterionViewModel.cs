//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalMeasurementCriterionViewModel
     /// </summary>
    public partial class GoalMeasurementCriterionViewModel : ViewModelBase, Interfaces.IGoalMeasurementCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurementCriterion";

        // member variable for the AccuracyPercent property
        private System.Decimal? _AccuracyPercent;

        // member variable for the AttemptsCount property
        private System.Int32? _AttemptsCount;

        // member variable for the GoalMeasurementId property
        private Guid _GoalMeasurementId;

        // member variable for the Metric property
        private System.String _Metric;

        // member variable for the SuccessCount property
        private System.Int32? _SuccessCount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalMeasurementCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Decimal? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Int32? AttemptsCount { get => _AttemptsCount; set => SetProperty(ref _AttemptsCount, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="GoalMeasurement"/> model
        /// </summary>
        public Guid GoalMeasurementId { get => _GoalMeasurementId; set => SetProperty(ref _GoalMeasurementId, value); }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.String Metric { get => _Metric; set => SetProperty(ref _Metric, value); }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Int32? SuccessCount { get => _SuccessCount; set => SetProperty(ref _SuccessCount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            AccuracyPercent = model.AccuracyPercent;
            AttemptsCount = model.AttemptsCount;
            GoalMeasurementId = model.GoalMeasurementId;
            Metric = model.Metric;
            SuccessCount = model.SuccessCount;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
