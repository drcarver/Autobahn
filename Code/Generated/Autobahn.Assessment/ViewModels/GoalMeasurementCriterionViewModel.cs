//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalMeasurementCriterionViewModel
     /// </summary>
    public partial class GoalMeasurementCriterionViewModel : ViewModelBase, Interfaces.IGoalMeasurementCriterionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurementCriterion";

        // member variable for the GoalMeasurementId property
        private Guid _GoalMeasurementId;

        // member variable for the AccuracyPercent property
        private System.Decimal? _AccuracyPercent;

        // member variable for the AttemptsCount property
        private System.Int32? _AttemptsCount;

        // member variable for the Metric property
        private System.String _Metric;

        // member variable for the SuccessCount property
        private System.Int32? _SuccessCount;

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
        /// The title of the GoalMeasurementCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="GoalMeasurementId"/> model
        /// </summary>
        public Guid GoalMeasurementId { get => _GoalMeasurementId; set => SetProperty(ref _GoalMeasurementId, value); }

        public System.Decimal? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        public System.Int32? AttemptsCount { get => _AttemptsCount; set => SetProperty(ref _AttemptsCount, value); }

        public System.String Metric  { get => _Metric; set => SetProperty(ref _Metric, value); }

        public System.Int32? SuccessCount { get => _SuccessCount; set => SetProperty(ref _SuccessCount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalMeasurementId = model.GoalMeasurementId;
            AccuracyPercent = model.AccuracyPercent;
            AttemptsCount = model.AttemptsCount;
            Metric = model.Metric;
            SuccessCount = model.SuccessCount;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
