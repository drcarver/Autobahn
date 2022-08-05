//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementViewModel
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementViewModel : ViewModelBase, Interfaces.IAssessmentNeedScreenEnhancement
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedScreenEnhancement";

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the InvertColorChoice property
        private System.Boolean? _InvertColorChoice;

        // member variable for the Magnification property
        private System.Decimal? _Magnification;

        // member variable for the AssessmentPersonalNeedsProfileScreenEnhancementId property
        private Guid? _AssessmentPersonalNeedsProfileScreenEnhancementId;

        // member variable for the ForegroundColor property
        private System.String _ForegroundColor;

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
        /// The title of the AssessmentNeedScreenEnhancementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        public System.Boolean? InvertColorChoice { get => _InvertColorChoice; set => SetProperty(ref _InvertColorChoice, value); }

        public System.Decimal? Magnification { get => _Magnification; set => SetProperty(ref _Magnification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileScreenEnhancementId"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get => _AssessmentPersonalNeedsProfileScreenEnhancementId; set => SetProperty(ref _AssessmentPersonalNeedsProfileScreenEnhancementId, value); }

        public System.String ForegroundColor  { get => _ForegroundColor; set => SetProperty(ref _ForegroundColor, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            InvertColorChoice = model.InvertColorChoice;
            Magnification = model.Magnification;
            AssessmentPersonalNeedsProfileScreenEnhancementId = model.AssessmentPersonalNeedsProfileScreenEnhancementId;
            ForegroundColor = model.ForegroundColor;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
