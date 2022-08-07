//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipControlViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipControlViewModel
     /// </summary>
    public partial class AssessmentNeedApipControlViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipControlViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipControl";

        // member variable for the AssessmentPersonalNeedsProfileControlId property
        private Guid _AssessmentPersonalNeedsProfileControlId;

        // member variable for the AssessmentNeedTimeMultiplier property
        private System.String _AssessmentNeedTimeMultiplier;

        // member variable for the LineReaderHighlightColor property
        private System.String _LineReaderHighlightColor;

        // member variable for the OverlayColor property
        private System.String _OverlayColor;

        // member variable for the BackgroundColor property
        private System.String _BackgroundColor;

        // member variable for the RefAssessmentNeedIncreasedWhitespacingTypeId property
        private Guid? _RefAssessmentNeedIncreasedWhitespacingTypeId;

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
        /// The title of the AssessmentNeedApipControlViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileControlId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileControlId { get => _AssessmentPersonalNeedsProfileControlId; set => SetProperty(ref _AssessmentPersonalNeedsProfileControlId, value); }

        public System.String AssessmentNeedTimeMultiplier  { get => _AssessmentNeedTimeMultiplier; set => SetProperty(ref _AssessmentNeedTimeMultiplier, value); }

        public System.String LineReaderHighlightColor  { get => _LineReaderHighlightColor; set => SetProperty(ref _LineReaderHighlightColor, value); }

        public System.String OverlayColor  { get => _OverlayColor; set => SetProperty(ref _OverlayColor, value); }

        public System.String BackgroundColor  { get => _BackgroundColor; set => SetProperty(ref _BackgroundColor, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get => _RefAssessmentNeedIncreasedWhitespacingTypeId; set => SetProperty(ref _RefAssessmentNeedIncreasedWhitespacingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipControl model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileControlId = model.AssessmentPersonalNeedsProfileControlId;
            AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier;
            LineReaderHighlightColor = model.LineReaderHighlightColor;
            OverlayColor = model.OverlayColor;
            BackgroundColor = model.BackgroundColor;
            RefAssessmentNeedIncreasedWhitespacingTypeId = model.RefAssessmentNeedIncreasedWhitespacingTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
