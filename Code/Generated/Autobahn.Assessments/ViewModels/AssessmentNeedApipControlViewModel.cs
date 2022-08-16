//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipControlViewModel
     /// </summary>
    public partial class AssessmentNeedApipControlViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipControl
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipControl";

        // member variable for the AssessmentNeedTimeMultiplier property
        private Guid? _AssessmentNeedTimeMultiplier;

        // member variable for the BackgroundColor property
        private  _BackgroundColor;

        // member variable for the LineReaderHighlightColor property
        private  _LineReaderHighlightColor;

        // member variable for the OverlayColor property
        private  _OverlayColor;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedIncreasedWhitespacingTypeId property
        private  _RefAssessmentNeedIncreasedWhitespacingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AssessmentNeedTimeMultiplier { get => _AssessmentNeedTimeMultiplier; set => SetProperty(ref _AssessmentNeedTimeMultiplier, value); }

        /// <summary>
        /// </summary>
        public  BackgroundColor { get => _BackgroundColor; set => SetProperty(ref _BackgroundColor, value); }

        /// <summary>
        /// </summary>
        public  LineReaderHighlightColor { get => _LineReaderHighlightColor; set => SetProperty(ref _LineReaderHighlightColor, value); }

        /// <summary>
        /// </summary>
        public  OverlayColor { get => _OverlayColor; set => SetProperty(ref _OverlayColor, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingType"/> model
        /// </summary>
        public  RefAssessmentNeedIncreasedWhitespacingTypeId { get => _RefAssessmentNeedIncreasedWhitespacingTypeId; set => SetProperty(ref _RefAssessmentNeedIncreasedWhitespacingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipControl model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier; // 
            BackgroundColor = model.BackgroundColor; // 
            LineReaderHighlightColor = model.LineReaderHighlightColor; // 
            OverlayColor = model.OverlayColor; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedIncreasedWhitespacingTypeId = model.RefAssessmentNeedIncreasedWhitespacingTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
