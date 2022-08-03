//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipControlViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipControlViewModel
     /// </summary>
    public partial class AssessmentNeedApipControlViewModel : BindableBase, IAssessmentNeedApipControl
    {
#region "Backing Fields"
        // member variable for the AssessmentNeedTimeMultiplier property
        private System.String _AssessmentNeedTimeMultiplier;

        // member variable for the LineReaderHighlightColor property
        private System.String _LineReaderHighlightColor;

        // member variable for the OverlayColor property
        private System.String _OverlayColor;

        // member variable for the BackgroundColor property
        private System.String _BackgroundColor;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileControlId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileControlId { get; set; }

        public System.String AssessmentNeedTimeMultiplier  { get => _AssessmentNeedTimeMultiplier; set => SetProperty(ref _AssessmentNeedTimeMultiplier, value); }

        public System.String LineReaderHighlightColor  { get => _LineReaderHighlightColor; set => SetProperty(ref _LineReaderHighlightColor, value); }

        public System.String OverlayColor  { get => _OverlayColor; set => SetProperty(ref _OverlayColor, value); }

        public System.String BackgroundColor  { get => _BackgroundColor; set => SetProperty(ref _BackgroundColor, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

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
        public void Load(IAssessmentNeedApipControl model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileControlId = model.AssessmentPersonalNeedsProfileControlId;
            AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier;
            LineReaderHighlightColor = model.LineReaderHighlightColor;
            OverlayColor = model.OverlayColor;
            BackgroundColor = model.BackgroundColor;
            RefAssessmentNeedIncreasedWhitespacingTypeId = model.RefAssessmentNeedIncreasedWhitespacingTypeId;
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
