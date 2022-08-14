//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
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

        // member variable for the Pitch property
        private System.Decimal? _Pitch;

        // member variable for the RefAssessmentNeedLinkIndicationTypeId property
        private Guid? _RefAssessmentNeedLinkIndicationTypeId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        // member variable for the SpeechRate property
        private System.Int32? _SpeechRate;

        // member variable for the Volume property
        private System.Decimal? _Volume;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedScreenReaderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? Pitch { get => _Pitch; set => SetProperty(ref _Pitch, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get => _RefAssessmentNeedLinkIndicationTypeId; set => SetProperty(ref _RefAssessmentNeedLinkIndicationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Int32? SpeechRate { get => _SpeechRate; set => SetProperty(ref _SpeechRate, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? Volume { get => _Volume; set => SetProperty(ref _Volume, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedScreenReader model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            Pitch = model.Pitch;
            RefAssessmentNeedLinkIndicationTypeId = model.RefAssessmentNeedLinkIndicationTypeId;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId;
            SpeechRate = model.SpeechRate;
            Volume = model.Volume;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
