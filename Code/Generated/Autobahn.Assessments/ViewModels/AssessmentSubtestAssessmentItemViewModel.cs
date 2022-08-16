//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItemViewModel
     /// </summary>
    public partial class AssessmentSubtestAssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentSubtestAssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestAssessmentItem";

        // member variable for the ItemWeightCorrect property
        private Guid? _ItemWeightCorrect;

        // member variable for the ItemWeightIncorrect property
        private  _ItemWeightIncorrect;

        // member variable for the ItemWeightNotAttempted property
        private  _ItemWeightNotAttempted;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ItemWeightCorrect { get => _ItemWeightCorrect; set => SetProperty(ref _ItemWeightCorrect, value); }

        /// <summary>
        /// </summary>
        public  ItemWeightIncorrect { get => _ItemWeightIncorrect; set => SetProperty(ref _ItemWeightIncorrect, value); }

        /// <summary>
        /// </summary>
        public  ItemWeightNotAttempted { get => _ItemWeightNotAttempted; set => SetProperty(ref _ItemWeightNotAttempted, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            ItemWeightCorrect = model.ItemWeightCorrect; // 
            ItemWeightIncorrect = model.ItemWeightIncorrect; // 
            ItemWeightNotAttempted = model.ItemWeightNotAttempted; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
