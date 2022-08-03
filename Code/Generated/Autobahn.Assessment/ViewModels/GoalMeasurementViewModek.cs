//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalMeasurementViewModel
     /// </summary>
    public partial class GoalMeasurementViewModel : BindableBase, IGoalMeasurement
    {
#region "Backing Fields"
        // member variable for the Description property
        private System.String _Description;

        // member variable for the Schedule property
        private System.String _Schedule;

        // member variable for the SuccessCriteria property
        private System.String _SuccessCriteria;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalId"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Schedule  { get => _Schedule; set => SetProperty(ref _Schedule, value); }

        public System.String SuccessCriteria  { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementTypeId"/> model
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get; set; }

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
        public void Load(IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            Description = model.Description;
            Schedule = model.Schedule;
            SuccessCriteria = model.SuccessCriteria;
            RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId;
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
