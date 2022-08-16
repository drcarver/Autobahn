//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationViewModel
     /// </summary>
    public partial class StaffEvaluationViewModel : ViewModelBase, Interfaces.IStaffEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluation";

        // member variable for the Outcome property
        private Guid? _Outcome;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefStaffPerformanceLevelId property
        private  _RefStaffPerformanceLevelId;

        // member variable for the Scale property
        private  _Scale;

        // member variable for the ScoreOrRating property
        private  _ScoreOrRating;

        // member variable for the System property
        private  _System;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Outcome { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevel"/> model
        /// </summary>
        public  RefStaffPerformanceLevelId { get => _RefStaffPerformanceLevelId; set => SetProperty(ref _RefStaffPerformanceLevelId, value); }

        /// <summary>
        /// </summary>
        public  Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// </summary>
        public  ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// </summary>
        public  System { get => _System; set => SetProperty(ref _System, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            Outcome = model.Outcome; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId; // 
            Scale = model.Scale; // 
            ScoreOrRating = model.ScoreOrRating; // 
            System = model.System; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
