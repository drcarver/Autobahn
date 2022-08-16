//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _AccuracyPercent;

        // member variable for the AttemptsCount property
        private  _AttemptsCount;

        // member variable for the Metric property
        private  _Metric;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the SuccessCount property
        private  _SuccessCount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        /// <summary>
        /// </summary>
        public  AttemptsCount { get => _AttemptsCount; set => SetProperty(ref _AttemptsCount, value); }

        /// <summary>
        /// </summary>
        public  Metric { get => _Metric; set => SetProperty(ref _Metric, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  SuccessCount { get => _SuccessCount; set => SetProperty(ref _SuccessCount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            AccuracyPercent = model.AccuracyPercent; // 
            AttemptsCount = model.AttemptsCount; // 
            Metric = model.Metric; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            SuccessCount = model.SuccessCount; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
