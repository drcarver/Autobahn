//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalMeasurementViewModel
     /// </summary>
    public partial class GoalMeasurementViewModel : ViewModelBase, Interfaces.IGoalMeasurementViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurement";

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Schedule property
        private System.String _Schedule;

        // member variable for the SuccessCriteria property
        private System.String _SuccessCriteria;

        // member variable for the RefGoalMeasurementTypeId property
        private Guid? _RefGoalMeasurementTypeId;

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
        /// The title of the GoalMeasurementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="GoalId"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Schedule  { get => _Schedule; set => SetProperty(ref _Schedule, value); }

        public System.String SuccessCriteria  { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementTypeId"/> model
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get => _RefGoalMeasurementTypeId; set => SetProperty(ref _RefGoalMeasurementTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            Description = model.Description;
            Schedule = model.Schedule;
            SuccessCriteria = model.SuccessCriteria;
            RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
