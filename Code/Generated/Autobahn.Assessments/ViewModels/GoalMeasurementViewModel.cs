//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the Description property
        private  _Description;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefGoalMeasurementTypeId property
        private  _RefGoalMeasurementTypeId;

        // member variable for the Schedule property
        private  _Schedule;

        // member variable for the SuccessCriteria property
        private Guid? _SuccessCriteria;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        public  RefGoalMeasurementTypeId { get => _RefGoalMeasurementTypeId; set => SetProperty(ref _RefGoalMeasurementTypeId, value); }

        /// <summary>
        /// </summary>
        public  Schedule { get => _Schedule; set => SetProperty(ref _Schedule, value); }

        /// <summary>
        /// </summary>
        public Guid? SuccessCriteria { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId; // 
            Schedule = model.Schedule; // 
            SuccessCriteria = model.SuccessCriteria; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
