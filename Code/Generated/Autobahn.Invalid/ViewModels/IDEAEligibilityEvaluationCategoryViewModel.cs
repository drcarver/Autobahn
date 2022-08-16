//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IDEAEligibilityEvaluationCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategoryViewModel
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryViewModel : ViewModelBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IDEAEligibilityEvaluationCategory";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIDEAEligibilityEvaluationCategoryId property
        private Guid? _RefIDEAEligibilityEvaluationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        public Guid? RefIDEAEligibilityEvaluationCategoryId { get => _RefIDEAEligibilityEvaluationCategoryId; set => SetProperty(ref _RefIDEAEligibilityEvaluationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIDEAEligibilityEvaluationCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIDEAEligibilityEvaluationCategoryId = model.RefIDEAEligibilityEvaluationCategoryId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
