//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalPerformanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalPerformanceViewModel
     /// </summary>
    public partial class GoalPerformanceViewModel : BindableBase, IGoalPerformance
    {
#region "Backing Fields"
        // member variable for the CurrentPerformanceDescription property
        private System.String _CurrentPerformanceDescription;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the Status property
        private System.String _Status;

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

        public System.String CurrentPerformanceDescription  { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        public System.String Status  { get => _Status; set => SetProperty(ref _Status, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusTypeId"/> model
        /// </summary>
        public Guid? RefGoalStatusTypeId { get; set; }

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
        public void Load(IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription;
            Date = model.Date;
            Status = model.Status;
            RefGoalStatusTypeId = model.RefGoalStatusTypeId;
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
