//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementCriterionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalMeasurementCriterionViewModel
     /// </summary>
    public partial class GoalMeasurementCriterionViewModel : BindableBase, IGoalMeasurementCriterion
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalMeasurementId"/> model
        /// </summary>
        public Guid GoalMeasurementId { get; set; }

        public System.Decimal? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        public System.Int32? AttemptsCount { get => _AttemptsCount; set => SetProperty(ref _AttemptsCount, value); }

        public System.String Metric  { get => _Metric; set => SetProperty(ref _Metric, value); }

        public System.Int32? SuccessCount { get => _SuccessCount; set => SetProperty(ref _SuccessCount, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalMeasurementId = model.GoalMeasurementId;
            AccuracyPercent = model.AccuracyPercent;
            AttemptsCount = model.AttemptsCount;
            Metric = model.Metric;
            SuccessCount = model.SuccessCount;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
