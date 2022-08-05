//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedScreenReader";

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        // member variable for the SpeechRate property
        private System.Int32? _SpeechRate;

        // member variable for the Pitch property
        private System.Decimal? _Pitch;

        // member variable for the Volume property
        private System.Decimal? _Volume;

        // member variable for the RefAssessmentNeedLinkIndicationTypeId property
        private Guid? _RefAssessmentNeedLinkIndicationTypeId;

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
        /// The title of the AssessmentPersonalNeedScreenReaderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        public System.Int32? SpeechRate { get => _SpeechRate; set => SetProperty(ref _SpeechRate, value); }

        public System.Decimal? Pitch { get => _Pitch; set => SetProperty(ref _Pitch, value); }

        public System.Decimal? Volume { get => _Volume; set => SetProperty(ref _Volume, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get => _RefAssessmentNeedLinkIndicationTypeId; set => SetProperty(ref _RefAssessmentNeedLinkIndicationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedScreenReader model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId;
            SpeechRate = model.SpeechRate;
            Pitch = model.Pitch;
            Volume = model.Volume;
            RefAssessmentNeedLinkIndicationTypeId = model.RefAssessmentNeedLinkIndicationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
