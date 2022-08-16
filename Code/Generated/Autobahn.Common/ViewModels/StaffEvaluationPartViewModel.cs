//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationPartViewModel
     /// </summary>
    public partial class StaffEvaluationPartViewModel : ViewModelBase, Interfaces.IStaffEvaluationPart
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluationPart";

        // member variable for the PartName property
        private  _PartName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the Scale property
        private  _Scale;

        // member variable for the ScoreOrRating property
        private  _ScoreOrRating;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  PartName { get => _PartName; set => SetProperty(ref _PartName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// </summary>
        public  ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluationPart model)
        {
            IsBusy = true;
            Id = model.Id;
            PartName = model.PartName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Scale = model.Scale; // 
            ScoreOrRating = model.ScoreOrRating; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
