//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private Guid? _CurrentPerformanceDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefGoalStatusTypeId property
        private  _RefGoalStatusTypeId;

        // member variable for the Status property
        private  _Status;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? CurrentPerformanceDescription { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusType"/> model
        /// </summary>
        public  RefGoalStatusTypeId { get => _RefGoalStatusTypeId; set => SetProperty(ref _RefGoalStatusTypeId, value); }

        /// <summary>
        /// </summary>
        public  Status { get => _Status; set => SetProperty(ref _Status, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefGoalStatusTypeId = model.RefGoalStatusTypeId; // 
            Status = model.Status; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
