//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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

        // member variable for the AssessmentPersonalNeedsProfileScreenEnhancementId property
        private Guid? _AssessmentPersonalNeedsProfileScreenEnhancementId;

        // member variable for the ForegroundColor property
        private System.String _ForegroundColor;

        // member variable for the InvertColorChoice property
        private System.Boolean? _InvertColorChoice;

        // member variable for the Magnification property
        private System.Decimal? _Magnification;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedScreenEnhancementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileScreenEnhancement"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get => _AssessmentPersonalNeedsProfileScreenEnhancementId; set => SetProperty(ref _AssessmentPersonalNeedsProfileScreenEnhancementId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.String ForegroundColor { get => _ForegroundColor; set => SetProperty(ref _ForegroundColor, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.Boolean? InvertColorChoice { get => _InvertColorChoice; set => SetProperty(ref _InvertColorChoice, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.Decimal? Magnification { get => _Magnification; set => SetProperty(ref _Magnification, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            AssessmentPersonalNeedsProfileScreenEnhancementId = model.AssessmentPersonalNeedsProfileScreenEnhancementId;
            ForegroundColor = model.ForegroundColor;
            InvertColorChoice = model.InvertColorChoice;
            Magnification = model.Magnification;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
